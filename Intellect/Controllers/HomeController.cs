using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Intellect.Models;
using Intellect.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace Intellect.Controllers
{
    public class HomeController : Controller
    {
        private readonly IntellectDbContext _intellectDbContext;
        private readonly UserManager<ExamUser> _userManager;
        private readonly SignInManager<ExamUser> _signInManager;
        static int exam_id = 0;
        static int? PreviousId = 0;
        //static int result = 0;
        static int correctAnswer = 0;
        static List<Question> RemainedQuestions = new List<Question>();
        static List<int> trueAnswers = new List<int>();

        public HomeController(IntellectDbContext intellectDbContext, UserManager<ExamUser> userManager, SignInManager<ExamUser> signInManager)
        {
            _intellectDbContext = intellectDbContext;
            _userManager = userManager;
            _signInManager = signInManager;
        }
         
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Test(int Id)
        {
            exam_id = Id;
            AdminViewModel admodel = new AdminViewModel();
            admodel.Equestions = await _intellectDbContext.Questions.Include(q => q.Answers).Where(q => q.ExamId == Id).ToListAsync();
            admodel.CurrentQuestion = await _intellectDbContext.Questions.Where(q => q.ExamId == Id).FirstOrDefaultAsync();
            RemainedQuestions = admodel.Equestions;
            PreviousId = admodel.CurrentQuestion.Id;
            return View(admodel);
        }


        [HttpGet]
        public async Task<IActionResult> Question(int Id, int count)
        {
            AdminViewModel admodel = new AdminViewModel();
            admodel.CurrentQuestion = await _intellectDbContext.Questions.Where(x => x.Id == Id).SingleOrDefaultAsync();
            admodel.Answers = await _intellectDbContext.Answers.Where(y => y.QuestionId == Id).ToListAsync();
            admodel.Equestions = await _intellectDbContext.Questions.Where(q => q.ExamId == exam_id).ToListAsync();
           
            // admodel.CurrentQuestion.Remainedtime = new TimeSpan(0, 0, 60);
             HttpContext.Session.SetString("currentQuestion_" + admodel.CurrentQuestion.Id, DateTime.Now.ToString());


            if (count > 1)
            {
                var question = RemainedQuestions.Single(r => r.Id == admodel.CurrentQuestion.Id);
                PreviousId = question.Id;
                RemainedQuestions.Remove(question);
                admodel.NextQuestion = RemainedQuestions[0];
                count -= 1;
            }
            else
            {
                admodel.NextQuestion = RemainedQuestions[0];
                count -= 1;
            }

            if (count == -1)
            {
                return RedirectToAction(nameof(Finish));
            }

            ViewBag.Equestions = count;

            return View(admodel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Question(int Id, int count, int myanswer)
        {
            AdminViewModel admodel = new AdminViewModel();
            admodel.CurrentQuestion = await _intellectDbContext.Questions.Where(x => x.Id == Id).SingleOrDefaultAsync();
            admodel.Answers = await _intellectDbContext.Answers.Where(y => y.QuestionId == Id).ToListAsync();
            admodel.Equestions = await _intellectDbContext.Questions.Where(q => q.ExamId == exam_id).ToListAsync();

            /*  var date = HttpContext.Session.GetString("currentQuestion_1");

              return Ok(new
              {
                  date,
                  Id,
                  HttpContext.Session.Keys
            */
            //  admodel.CurrentQuestion.Remainedtime = new TimeSpan(0, 0, 60);        
            //  var interval = DateTime.Now - DateTime.Parse(HttpContext.Session.GetString("currentQuestion_" + Id));

            var sesdata = HttpContext.Session.GetString("currentQuestion_" + PreviousId);
            var interval = DateTime.Now - DateTime.Parse(sesdata);

            correctAnswer = _intellectDbContext.Answers.Where(a => a.QuestionId == PreviousId && a.Correct == true).SingleOrDefault().Id;

            if (_signInManager.IsSignedIn(User))
            {
                ExamUser examTaker = await _userManager.GetUserAsync(HttpContext.User);

                examTaker.TestTaker = await _intellectDbContext.TestTakers
                                               .Include(tt => tt.UserQuestions) 
                                               .Where(t => t.Id == examTaker.TestTakerId) 
                                               .FirstOrDefaultAsync();
                admodel.CurrentQuestion = examTaker.TestTaker.UserQuestions.Select(u => u.Question).Where(x => x.Id == Id).SingleOrDefault();

                if (myanswer == correctAnswer)
                {
                    admodel.CurrentQuestion.Score = 60 - (int)interval.TotalMilliseconds / 1000;
                    await _intellectDbContext.SaveChangesAsync();
                    // admodel.CurrentQuestion.Score = result;
                }
            }
             
                if (count > 1)
            {
                var question = RemainedQuestions.Single(r => r.Id == admodel.CurrentQuestion.Id);
                PreviousId = question.Id;
                RemainedQuestions.Remove(question);
                admodel.NextQuestion = RemainedQuestions[0];
                count -= 1;
            }
            else
            {
                admodel.NextQuestion = RemainedQuestions[0];
                count -= 1;
            }

            if(count == -1)
            {
                return RedirectToAction(nameof(Finish));
            }

            ViewBag.Equestions = count;

            return RedirectToAction(nameof(Question));
        }
        
        public async Task<IActionResult> Finish()
        {
            if (_signInManager.IsSignedIn(User))
            {
                int a = 0;
                ExamUser examTaker = await _userManager.GetUserAsync(HttpContext.User);

                examTaker.TestTaker = await _intellectDbContext.TestTakers.FirstOrDefaultAsync();
                Exam exam = await _intellectDbContext.Exams.Where(e => e.Id == exam_id).SingleOrDefaultAsync();
                foreach(Question question in exam.Questions)
                {
                      a = a += question.Score;  
                }
              //  examTaker.TestTaker.Result = result;
              await _intellectDbContext.SaveChangesAsync();

                return RedirectToAction(nameof(Privacy));
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
