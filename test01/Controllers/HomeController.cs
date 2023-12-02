using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.name = "Show you Home Page";
            return View();
        }
        //Defferent Name
        [ActionName("Info")]
        public ActionResult ShowInfo()
        {
            return View("Show");
        }
        //In Share Folder

        [NonAction]
        public ActionResult Detail()
        {
            return View("Details");
        }
        //Different Controller
        [HttpPost]
        public ActionResult ShowMoreDetail()
        {
            return View("~/Views/About/MyProfile.cshtml");
        }
        
    }
}