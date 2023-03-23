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

using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace ELearning.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task Signingoogle()
        {
            await HttpContext.ChallengeAsync(GoogleDefaults.AuthenticationScheme, new AuthenticationProperties()
            {
                RedirectUri = Url.Action("GoogleResponse")
             });
        }

        public async Task<IActionResult> GoogleResponse()
        {
            //LINQ
            var result = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            var claims = result.Principal.Identities.FirstOrDefault().Claims.Select(claim => new Root
            {
                issuer = claim.Issuer,
                originalIssuer = claim.OriginalIssuer,
                type = claim.Type,
                value = claim.Value
            }).ToList();
            foreach (var i in claims)
            {
                string k = i.value;
            }
            string email = claims.SingleOrDefault(x => x.type.Contains("emailaddress")).value;
            string givenname = claims.SingleOrDefault(x => x.type.Contains("givenname")).value;

            Account acc = new Account(givenname, true, email, "", email, "Null", 2, true);
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var exist = learningEnglishContext.Accounts.SingleOrDefault(x => x.Email.Equals(email));
            if (exist != null)
            {
               
                var username = JsonConvert.SerializeObject(acc.UserName);
                var role = JsonConvert.SerializeObject(acc.RoleId);
                var act = Newtonsoft.Json.JsonConvert.SerializeObject(acc);
                HttpContext.Session.SetString("username", username);
                HttpContext.Session.SetString("role", role);
                HttpContext.Session.SetString("act", act);
                //return Json(claims);
                return RedirectToAction("Index");
            }
            else
            {
                learningEnglishContext.Accounts.Add(acc);
                learningEnglishContext.SaveChanges();
                var username = JsonConvert.SerializeObject(acc.UserName);
                var role = JsonConvert.SerializeObject(acc.RoleId);
                var act = Newtonsoft.Json.JsonConvert.SerializeObject(acc);
                HttpContext.Session.SetString("username", username);
                HttpContext.Session.SetString("role", role);
                HttpContext.Session.SetString("act", act);
                return RedirectToAction("Index");
            }

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
            var list = (from j in learningEnglishContext.Questions
                       // join j in learningEnglishContext.Tests on i.Id equals j.ModuleId
                        where j.ModuleId == 1
                        select j).ToList();

            var list1 = (from j in learningEnglishContext.Answers
                         select j).ToList();
            return View(list);
           // var rand = new Random();
            //var selectedPost = list.Take(5).ToList();
           // return View(selectedPost);
        }
        public IActionResult Sentence(int? id)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var list = (from i in learningEnglishContext.Modules
                        join j in learningEnglishContext.Sentences on i.Id equals j.ModuleId
                        where j.ModuleId == 1
                        select j).ToList();
            
            return View(list);
        }



         public IActionResult Mark(IFormCollection iformCollection)
        {
            int score = 0;
            string[] questionId = iformCollection["questionId"];
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            foreach (var i in questionId)
            {
                int idAnswerCorrect = learningEnglishContext.Answers.Where(a => a.Correct == true && a.QuestionId == Convert.ToInt32(i)).FirstOrDefault().Id;
                if (idAnswerCorrect == Convert.ToInt32(iformCollection["question_" + i]))
                {
                    score++;
                }
            }
            ViewBag.score = score;
            return RedirectToAction("Login");
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult DoSignup(Account account)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var acc = learningEnglishContext.Accounts.FirstOrDefault(x => x.Email.Equals(account.Email));
            if (acc == null)
            {
                account.FullName = account.Email;
                account.Password = EncodePassword(account.Password);
                account.RoleId = 2;
                account.Status = true;
                account.Gender = true;
                account.ContactNo = "Null";
                account.UserName = account.Email;
                learningEnglishContext.Accounts.Add(account);
                learningEnglishContext.SaveChanges();
                var username = JsonConvert.SerializeObject(account.UserName);
                var role = JsonConvert.SerializeObject(account.RoleId);
                var act = Newtonsoft.Json.JsonConvert.SerializeObject(account);
                HttpContext.Session.SetString("username", username);
                HttpContext.Session.SetString("role", role);
                HttpContext.Session.SetString("act", act);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Login");
        }

        public IActionResult DoLogin(Account account)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();

            var acc = learningEnglishContext.Accounts.SingleOrDefault(x => x.Email.Equals(account.Email) && (x.Password).Equals(account.Password));
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
            else
            {
                ViewBag.NoAccount = " Account is not exist";

                return RedirectToAction("Login");
            }
        }

        public static string EncodePassword(string password)
        {
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string hashed = Convert.ToBase64String(encData_byte);
                return hashed;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }

        public string DecodePassword(string encodedData)
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder utf8Decode = encoder.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(encodedData);
            int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            string result = new String(decoded_char);
            return result;
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
