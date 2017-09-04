using ATtuing.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATtuing.BackWeb.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
             string x = "555v"; ;
            Convert.ToInt32(x);
            return View();
        }
        [HttpGet]
        public ActionResult GetAuthCode()
        {
            return File(new VerifyCode().GetVerifyCode(), @"image/Gif");
        }
    }
}