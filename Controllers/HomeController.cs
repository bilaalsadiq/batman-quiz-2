using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using batman_quiz_2.Models;

namespace batman_quiz_2.Controllers
{
    public class HomeController : Controller
    {

        private BatmanQuizEntities db = new BatmanQuizEntities();
        public ActionResult Index()
        {
            var questions = from q in db.quiz_singletable
                            select q;

            return View(questions);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}