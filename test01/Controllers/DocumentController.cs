using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test01.Controllers
{
    public class DocumentController : Controller
    {
        // GET: Document
        public ActionResult Index()
        {
            return View();
        }
        public RedirectResult ShowInternal()
        {
            return Redirect("/Home/ShowInfo");
        }
        public RedirectResult ShowExternal()
        {
            return Redirect("https://google.com");
        }
    }
}