using ATtuing.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATtuing.BackWeb.Areas.SystemManage.Controllers
{
    public class RoleController : Controller
    {
        public IRoleService RoleService { get; set; }
        // GET: SystemManage/Role
        public ActionResult Index()
        {
           var xx= RoleService.GetById(1);
            return View();
        }

        public ActionResult AddRole() {
          var xx=  RoleService.AddRole();
            return View();
        }
    }
}