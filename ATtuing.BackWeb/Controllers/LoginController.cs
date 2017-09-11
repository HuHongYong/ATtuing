using ATtuing.Common;
using ATtuing.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATtuing.BackWeb.Controllers
{
    public class LoginController : Controller
    {
        public IEQEventService EQEventService { get; set; }
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
             string x = "5565v"; ;
            var xx=EQEventService.GetById();
            return View();
        }
        [HttpGet]
        public ActionResult GetAuthCode()
        {
            return File(new VerifyCode().GetVerifyCode(), @"image/Gif");
        }
    }
}