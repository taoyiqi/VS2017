using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyIocTest.Models;

namespace MyIocTest.Controllers
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

        public ActionResult IocTest()
        {
            ViewBag.Message = "Your IocTest page.";

            UserInfo userInfo = IocService.GetObject("UserInfo") as UserInfo;
            if (userInfo!=null)
            {
                ViewBag.Message = "Your IocTest page.userInfo Is Not NULL";
            }
            else
            {
                ViewBag.Message = "Your IocTest page.userInfo Is NULL";
            }

            return View();
        }
    }
}