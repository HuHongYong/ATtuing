using ATtuing.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATtuing.BackWeb.App_Start
{
    public abstract class BaseController : Controller
    {
        [HttpGet]
        public virtual ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public virtual ActionResult Form()
        {
            return View();
        }
        [HttpGet]
        public virtual ActionResult Details()
        {
            return View();
        }
        protected virtual ActionResult Success(string message)
        {
            return Json(new AjaxResult { state = ResultType.success.ToString(), message = message });
        }
        protected virtual ActionResult Success(string message, object data)
        {
            return Json(new AjaxResult { state = ResultType.success.ToString(), message = message, data = data });
        }
        protected virtual ActionResult Error(string message)
        {
            return Json(new AjaxResult { state = ResultType.error.ToString(), message = message });
        }
    }
}