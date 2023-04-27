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
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authentication.Cookies;
using VietLish.DTO;
using System.Web;

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
            string username = claims[1].value;
            string fullname = claims.SingleOrDefault(x => x.type.Contains("givenname")).value;
            Account acc = new Account(fullname, true, email, "", "DefaultValue", "000000", 2, true);
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var exist = learningEnglishContext.Accounts.SingleOrDefault(x => x.Email.Equals(email));
            if (exist != null)
            {
                var username1 = JsonConvert.SerializeObject(acc.FullName);
                var role = JsonConvert.SerializeObject(acc.RoleId);
                var act = Newtonsoft.Json.JsonConvert.SerializeObject(acc);
                var userId = Newtonsoft.Json.JsonConvert.SerializeObject(exist.Id);
                HttpContext.Session.SetString("username", username1);
                HttpContext.Session.SetString("role", role);
                HttpContext.Session.SetString("act", act);
                HttpContext.Session.SetString("userId", userId);
                return RedirectToAction("Index");
            }
            else
            {
                learningEnglishContext.Accounts.Add(acc);
                learningEnglishContext.SaveChanges();
                var username2 = JsonConvert.SerializeObject(acc.FullName);
                var role = JsonConvert.SerializeObject(acc.RoleId);
                var act = Newtonsoft.Json.JsonConvert.SerializeObject(acc);
                var userId = Newtonsoft.Json.JsonConvert.SerializeObject(acc.Id);
                HttpContext.Session.SetString("username", username2);
                HttpContext.Session.SetString("role", role);
                HttpContext.Session.SetString("act", act);
                HttpContext.Session.SetString("userId", userId);
                return RedirectToAction("Index");
            }
        }

        public IActionResult Index(int? id, int? page)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var list = learningEnglishContext.Levels.ToList();
            ViewBag.Active = "5";
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

        public IActionResult EnrollLevel(int? id, int? page)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            string? userId = HttpContext.Session.GetString("userId");
            string userId1 = JsonConvert.DeserializeObject<string>(userId);

            var list1 =
                 (from i in learningEnglishContext.Modules
                  join j in learningEnglishContext.Parts on i.PartId equals j.Id
                  join l in learningEnglishContext.Levels on i.LevelId equals l.Id
                  where i.LevelId == id
                  select new
                  {
                      Id = i.Id,
                      Module = i.Module1,
                      Image = i.Image,
                      Part = j.PartName,
                      Level = l.Level1
                  }).ToList();

            List<ModuleDTO> list = new List<ModuleDTO>();
            foreach (var i in list1)
            {
                var pass = learningEnglishContext
                    .Results.SingleOrDefault(x => x.AccountId == Convert.ToInt32(userId1) && x.ModuleId == i.Id);
                if (pass != null)
                {
                    if (pass.Status == true)
                    {
                        list.Add(new ModuleDTO(i.Id, i.Module, i.Part, i.Level, i.Image, true));
                    }
                    else if (pass.Status == false)
                    {
                        list.Add(new ModuleDTO(i.Id, i.Module, i.Part, i.Level, i.Image, false));
                    }
                }
                else if (pass == null)
                {
                    list.Add(new ModuleDTO(i.Id, i.Module, i.Part, i.Level, i.Image, null));
                }
            }
            if (page > 0)
            {
                page = page;
            }
            else
            {
                page = 1;
            }
            ViewBag.moduleId = id;
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

        public IActionResult ViewModule(int? id, int? page)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var list =
            (from i in learningEnglishContext.Modules
             join j in learningEnglishContext.VocabInModule on i.Id equals j.ModuleId
             where i.Id == id
             select new Vocabulary { Id = i.Id, Image = j.Image, Word = j.Word, Pronunciation = j.Pronunciation, Meaning = j.Meaning }).ToList();

            if (page > 0)
            {
                page = page;
            }
            else
            {
                page = 1;
            }
            ViewBag.moduleId = id;
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
                        where j.ModuleId == id
                        select j).ToList();
            var list1 = (from j in learningEnglishContext.Answers
                         select j).ToList();
            //ViewBag.ModuleId = id;
            foreach (var i in list)
            {
                var x = i.Answers;
            }
            var moduleId = Newtonsoft.Json.JsonConvert.SerializeObject(id);
            HttpContext.Session.SetString("moduleId", moduleId);
            return View(list);
        }

        public IActionResult ViewMark()
        {
            string? id = HttpContext.Session.GetString("userId");
            string userId = JsonConvert.DeserializeObject<string>(id);
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var userMark = (from pl in learningEnglishContext.Results
                            join module in learningEnglishContext.Modules on pl.ModuleId equals module.Id
                            join level in learningEnglishContext.Levels on module.LevelId equals level.Id
                            select new
                            {
                                Module = module.Module1,
                                Level = level.Level1,
                                Status = pl.Status
                            }).ToList();

            List<ResultDTO> list = new List<ResultDTO>();
            foreach (var i in userMark)
            {
                list.Add(new ResultDTO(i.Module, i.Level, i.Status));
            }
            ViewBag.Active = "6";
            return View(list);
            //return RedirectToAction("Index");
        }

        public IActionResult Mark(IFormCollection iformCollection)
        {

            Account account = new Account();
            string? account1 = HttpContext.Session.GetString("act");

            account = JsonConvert.DeserializeObject<Account>(account1);

            string? id = HttpContext.Session.GetString("moduleId");
            string moduleId = JsonConvert.DeserializeObject<string>(id);

            string? userId = HttpContext.Session.GetString("userId");
            string userId1 = JsonConvert.DeserializeObject<string>(userId);


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

            var available = learningEnglishContext.Results
                .SingleOrDefault(x => x.AccountId == Convert.ToInt32(userId1) && x.ModuleId == Convert.ToInt32(moduleId));

            if (available != null)
            {
                available.Status = score >= 5 ? true : false;
                learningEnglishContext.SaveChanges();
            }
            else
            {
                Result result = new Result();
                result.AccountId = Convert.ToInt32(userId1);
                result.ModuleId = Convert.ToInt32(moduleId);
                result.Status = score >= 5 ? true : false;
                learningEnglishContext.Results.Add(result);
                learningEnglishContext.SaveChanges();
            }
            ViewBag.score = score;
            return View();
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
                account.FullName = "account.Email";
                account.Password = EncodePassword(account.Password);
                account.RoleId = 2;
                account.Status = true;
                account.Gender = true;
                account.ContactNo = "0971858758";
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

            var acc = learningEnglishContext.Accounts.FirstOrDefault(x => x.Email.Equals(account.Email) && (x.Password).Equals(account.Password));
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
                ViewBag.NoAccount = "Account is not exist";
                return RedirectToAction("Login");
            }
        }

        public static string EncodePassword(string password)
        {
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
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

        public IActionResult SentenceStructure(int? page)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var listSentence = (from sc in learningEnglishContext.Sentences
                                join module in learningEnglishContext.Modules on sc.ModuleId equals module.Id
                                select new
                                {
                                    Id = sc.Id,
                                    Module = module.Module1,
                                    Sentence = sc.Sentence
                                }
                           ).ToList();

            List<SentenceStructureDTO> list = new List<SentenceStructureDTO>();
            foreach (var i in listSentence)
            {
                list.Add(new SentenceStructureDTO(i.Id, i.Module, i.Sentence));
            }

            ViewBag.Active = "7";
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

        public IActionResult SentenceManagement(int? page)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var listSentence = (from sc in learningEnglishContext.Sentences
                                join module in learningEnglishContext.Modules on sc.ModuleId equals module.Id
                                select new
                                {
                                    Id = sc.Id,
                                    Module = module.Module1,
                                    ModuleId = module.Id,
                                    Sentence = sc.Sentence
                                }
                           ).ToList();

            List<SentenceStructureDTO> list = new List<SentenceStructureDTO>();
            foreach (var i in listSentence)
            {
                list.Add(new SentenceStructureDTO(i.Id, i.Module, i.ModuleId, i.Sentence));
            }

            ViewBag.Active = "8";
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

        public IActionResult SentenceStructureDelete(int? id)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var sentence = learningEnglishContext.Sentences.SingleOrDefault(x => x.Id == id);
            if (sentence != null)
            {
                learningEnglishContext.Sentences.Remove(sentence);
                learningEnglishContext.SaveChanges();
            }
            return RedirectToAction("SentenceManagement");
        }

        public IActionResult AddNewSentence()
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            ViewBag.Module = learningEnglishContext.Modules.ToList();
            return View();
        }

        public IActionResult DoAddSentence(SentenceStructure sentence)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            sentence.Level = "Default";
            learningEnglishContext.Sentences.Add(sentence);
            learningEnglishContext.SaveChanges();
            return RedirectToAction("SentenceManagement");
        }

        public IActionResult AccountManagement(int? page)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var listAcc = learningEnglishContext.Accounts.ToList();
            ViewBag.Active = "1";
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
            int total = listAcc.Count();
            ViewBag.total = total;
            ViewBag.pageCurrent = page;
            float numberPage = (total / limit);
            ViewBag.numberPage = (int)Math.Ceiling(numberPage) + 1;
            var data = listAcc.OrderBy(s => s.Id).Skip(start).Take(limit).ToList();
            return View(data);
        }

        public IActionResult UpdateAccount(int? id)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var acc = learningEnglishContext.Accounts.SingleOrDefault(x => x.Id == id);
            if (acc != null)
            {
                if (acc.Status == true)
                {
                    acc.Status = false;
                    learningEnglishContext.SaveChanges();
                }
                else
                {
                    acc.Status = true;
                    learningEnglishContext.SaveChanges();
                }
            }
            return RedirectToAction("AccountManagement");
        }

        public IActionResult ModuleManagement(int? page)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var listModule = (from module in learningEnglishContext.Modules
                              join part in learningEnglishContext.Parts on module.PartId equals part.Id
                              join level in learningEnglishContext.Levels on module.LevelId equals level.Id
                              select new
                              {
                                  Id = module.Id,
                                  Module = module.Module1,
                                  Part = part.PartName,
                                  Level = level.Level1,
                                  Image = module.Image
                              }).ToList();
            ViewBag.Active = "2";
            List<ModuleDTO> list = new List<ModuleDTO>();

            foreach (var i in listModule)
            {
                list.Add(new ModuleDTO(i.Id, i.Module, i.Part, i.Level, i.Image));
            }

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

        public IActionResult UpdateModule(int? id)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var module = learningEnglishContext.Modules.SingleOrDefault(x => x.Id == id);
            ViewBag.Active = "2";
            if (module != null)
            {
                var part = learningEnglishContext.Parts.ToList();
                var level = learningEnglishContext.Levels.ToList();
                ViewBag.PartId = module.PartId;
                ViewBag.LevelId = module.LevelId;
                ViewBag.Part = part;
                ViewBag.Level = level;
                return View(module);
            }
            return RedirectToAction("ModuleManagement");
        }

        public IActionResult AddNewModule()
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            ViewBag.Active = "2";
            var part = learningEnglishContext.Parts.ToList();
            var level = learningEnglishContext.Levels.ToList();
            ViewBag.Part = part;
            ViewBag.Level = level;
            return View();
        }

        public IActionResult DoAddModule(Module module)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            if (module != null)
            {
                module.Image = "/img/module/" + module.Image;
                learningEnglishContext.Modules.Add(module);
                learningEnglishContext.SaveChanges();
            }
            ViewBag.Active = "2";
            return RedirectToAction("ModuleManagement");
        }

        public IActionResult DoUpdateModule(Module module)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            ViewBag.Active = "2";
            var mol = learningEnglishContext.Modules.SingleOrDefault(x => x.Id == module.Id);
            if (mol != null)
            {
                mol.Module1 = module.Module1;
                mol.PartId = module.PartId;
                mol.LevelId = module.LevelId;
                if (module.Image != null)
                {
                    mol.Image = module.Image;
                }
                learningEnglishContext.SaveChanges();
            }
            return RedirectToAction("ModuleManagement");
        }

        public IActionResult QuizManagement(int? page)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var quiz = (from ques in learningEnglishContext.Questions
                        join module in learningEnglishContext.Modules on ques.ModuleId equals module.Id
                        select new
                        {
                            Id = ques.Id,
                            Question = ques.Question1,
                            Module = module.Module1,
                            listAnswer = ques.Answers
                        }).ToList();
            ViewBag.Active = "3";
            List<QuizDTO> list = new List<QuizDTO>();

            foreach (var i in quiz)
            {
                list.Add(new QuizDTO(i.Id, i.Question, i.Module, i.listAnswer));
            }

            if (page > 0)
            {
                page = page;
            }
            else
            {
                page = 1;
            }
            int limit = 10;
            int start = (int)(page - 1) * limit;
            int total = list.Count();
            ViewBag.total = total;
            ViewBag.pageCurrent = page;
            float numberPage = (total / limit);
            ViewBag.numberPage = (int)Math.Ceiling(numberPage) + 1;
            var data = list.OrderBy(s => s.Id).Skip(start).Take(limit).ToList();
            return View(data);
        }

        public IActionResult WordManagement(int? page)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var listVocab = (from module in learningEnglishContext.Modules
                             join vocab in learningEnglishContext.VocabInModule on module.Id equals vocab.ModuleId
                             select new
                             {
                                 Id = vocab.Id,
                                 Module = module.Module1,
                                 Image = vocab.Image,
                                 Word = vocab.Word,
                                 Pronunciation = vocab.Pronunciation,
                                 Meaning = vocab.Meaning,                               
                             }).ToList();
            ViewBag.Active = "4";
            List<VocabDTO> list = new List<VocabDTO>();

            foreach (var i in listVocab)
            {
                list.Add(new VocabDTO(i.Id, i.Module, i.Image, i.Word, i.Pronunciation, i.Meaning));
            }

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

        public IActionResult UpdateWord(int? id)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var word = learningEnglishContext.VocabInModule.SingleOrDefault(x => x.Id == id);
            var module = learningEnglishContext.Modules.ToList();
            if (word != null)
            {
                ViewBag.ModuleId = word.ModuleId;
                ViewBag.Module = module;
                return View(word);
            }
            return RedirectToAction("WordManagement");
        }

        public IActionResult UpdateQuiz(int? id)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            ViewBag.Active = "3";
            var question = learningEnglishContext.Questions.SingleOrDefault(x => x.Id == id);
            var module = learningEnglishContext.Modules.ToList();
            var quiz = (from j in learningEnglishContext.Answers
                        where j.QuestionId == id
                        select j).ToList();
            if (question != null)
            {
                ViewBag.ModuleId = question.ModuleId;
                ViewBag.Module = module;
                return View(question);
            }
            return RedirectToAction("QuizManagement");
        }

        public IActionResult DeleteQuiz(int? id)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            ViewBag.Active = "3";
            var question = learningEnglishContext.Questions.SingleOrDefault(x => x.Id == id);
            var module = learningEnglishContext.Modules.ToList();
            learningEnglishContext.Answers.RemoveRange(learningEnglishContext.Answers.Where(x => x.QuestionId == question.Id));
            learningEnglishContext.Questions.Remove(question);
            learningEnglishContext.SaveChanges();
            return RedirectToAction("QuizManagement");
        }

        public IActionResult AddNewQuiz()
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            ViewBag.Active = "3";
            var module = learningEnglishContext.Modules.ToList();
            ViewBag.Module = module;
            return View();
        }

        public IActionResult DoAddQuiz(string question, string correct, string moduleId, string answer1, string answer2, string answer3, string answer4)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            ViewBag.Active = "3";
            bool correctAnswerA = false, correctAnswerB = false, correctAnswerC = false, correctAnswerD = false;
            List<Answer> list = new List<Answer>();
            if (correct.Equals("Answer1"))
            {
                correctAnswerA = true;
            }
            if (correct.Equals("Answer2"))
            {
                correctAnswerB = true;
            }
            if (correct.Equals("Answer3"))
            {
                correctAnswerC = true;
            }
            if (correct.Equals("Answer4"))
            {
                correctAnswerD = true;
            }
            //list.Add(new Answer());
            Question quest = new Question(Convert.ToInt32(moduleId), question);
            learningEnglishContext.Questions.Add(quest);
            learningEnglishContext.SaveChanges();
            int idQuest = quest.Id;
            list.Add(new Answer(idQuest, answer1, correctAnswerA));
            list.Add(new Answer(idQuest, answer2, correctAnswerB));
            list.Add(new Answer(idQuest, answer3, correctAnswerC));
            list.Add(new Answer(idQuest, answer4, correctAnswerD));

            foreach (var i in list)
            {
                learningEnglishContext.Answers.Add(i);
                learningEnglishContext.SaveChanges();
            }

            return RedirectToAction("QuizManagement");
        }

        public IActionResult AddNewWord()
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            ViewBag.Active = "4";
            var module = learningEnglishContext.Modules.ToList();
            ViewBag.Module = module;
            return View();
        }

        public IActionResult DoUpdateWord(Vocabulary vocabulary)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            ViewBag.Active = "4";
            var vocabInModule1 = learningEnglishContext.VocabInModule.SingleOrDefault(x => x.Id == vocabulary.Id);
            if (vocabInModule1 != null)
            {
                vocabInModule1.Word = vocabulary.Word;
                vocabInModule1.Pronunciation = vocabulary.Pronunciation;
                vocabInModule1.Meaning = vocabulary.Meaning;
              
                if (vocabulary.Image != null)
                {
                    vocabInModule1.Image = vocabulary.Image;
                }
                learningEnglishContext.SaveChanges();
            }
            return RedirectToAction("WordManagement");
        }

        public IActionResult DoAddNewWord(Vocabulary vocabulary)
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            if(vocabulary != null)
            {
                vocabulary.Image = "/img/vocab/" + vocabulary.Image;
                learningEnglishContext.VocabInModule.Add(vocabulary);
                learningEnglishContext.SaveChanges();

            }
            ViewBag.Active = "4";
            return RedirectToAction("WordManagement");
        }

      
        public IActionResult PartManagement()
        {
            LearningEnglishContext learningEnglishContext = new LearningEnglishContext();
            var listSentenceStructure = learningEnglishContext.Parts.ToList();
            return View(listSentenceStructure);
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
