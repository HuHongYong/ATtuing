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
        public ActionResult IndexSql()
        {
            var xx = EQEventService.GetByIdSql();
            return Json(xx);
        }
        public ActionResult IndexInclude()
        {
            var xx = EQEventService.IncludeEQEvent();
            return Json(xx);
        }
        //一对多最佳测试
        public ActionResult Index1() {
            var xx = EQEventService.GetEQEventTask();
            return View();
        }
    }
}