using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeworkW5D1_Website_ASP.Controllers
{
    public class HomeworkController : Controller
    {
        // GET: Homework
        public ActionResult Index(string word, int integer = 1)
        {
            ViewBag.Word = word;
            ViewBag.Integer = integer;
            return View();
        }
    }
}