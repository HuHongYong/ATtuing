using ATtuing.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATtuing.BackWeb.Controllers
{
    public class TestController : Controller
    {
        public IEQEventService EQEventService { get; set; }
        // GET: Test
        public ActionResult Index()
        {
            var xx = EQEventService.GetById();
            return Json(xx);
        }
    }
}