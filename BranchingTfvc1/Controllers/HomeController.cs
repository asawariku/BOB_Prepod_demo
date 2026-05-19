using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BranchingTfvc1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
//added data for the powershell demo
//added data for powershell demo 2
//added data for feature branch
//added  data to check new powershell
//To check 1
//Asawari
//Asawari-test1
//Test1
//Test2
//Test3