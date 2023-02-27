using ELearning.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ELearning.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int? id, int? page)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var list = learningEnglishContext.Levels.ToList();

            if (page > 0)
            {
                page = page;
            }
            else
            {
                page = 1;
            }
            int limit = 5;
            int start = (int)(page - 1) * limit;
            int total = list.Count();
            ViewBag.total = total;
            ViewBag.pageCurrent = page;
            float numberPage = (total / limit);
            ViewBag.numberPage = (int) Math.Ceiling(numberPage) + 1;
            var data = list.OrderBy(s => s.Id).Skip(start).Take(limit).ToList();
            return View(data);
        }

        public IActionResult EnrollLevel(int? id, int? page)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var list = (from i in learningEnglishContext.Modules
                        join j in learningEnglishContext.VocabInModule on i.Id equals j.ModuleId
                        where i.LevelId == id
                        select new Vocabulary { Image = j.Image, Word = j.Word, Means=j.Means, Pronunciation = j.Pronunciation }).ToList();

            if (page > 0)
            {
                page = page;
            }
            else
            {
                page = 1;
            }
            int limit = 5;
            int start = (int)(page - 1) * limit;
            int total = list.Count();
            ViewBag.total = total;
            ViewBag.pageCurrent = page;
            float numberPage = (total / limit);
            ViewBag.numberPage = (int)Math.Ceiling(numberPage) + 1;
            var data = list.OrderBy(s => s.Id).Skip(start).Take(limit).ToList();
            return View(data);
        }

        public IActionResult TestModule(int? id)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var list = (from i in learningEnglishContext.Modules
                        join j in learningEnglishContext.Tests on i.Id equals j.ModuleId
                        where j.ModuleId == 1
                        select j).ToList();
            var rand = new Random();
            var selectedPost = list.Take(5).ToList();
            return View(selectedPost);
        }

        public IActionResult Mark(List<Test> tl) 
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var list = (from i in learningEnglishContext.Modules
                        join j in learningEnglishContext.Tests on i.Id equals j.ModuleId
                        where j.ModuleId == 1
                        select j).ToList();
            var rand = new Random();
            var selectedPost = list.Take(5).ToList();
            return RedirectToAction("Login");
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult DoLogin(Account account)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var acc = learningEnglishContext.Accounts.FirstOrDefault(x => x.UserName.Equals(account.UserName) && x.Password.Equals(account.Password));
            if (acc != null)
            {
                var username = JsonConvert.SerializeObject(acc.UserName);
                var role = JsonConvert.SerializeObject(acc.RoleId);
                var act = Newtonsoft.Json.JsonConvert.SerializeObject(acc);
                HttpContext.Session.SetString("username", username);
                HttpContext.Session.SetString("role", role);
                HttpContext.Session.SetString("act", act);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Login");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("act");
            HttpContext.Session.Remove("role");
            HttpContext.Session.Remove("username");
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
