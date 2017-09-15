using ATtuing.BackWeb.App_Start;
using ATtuing.Common;
using ATtuing.Dto;
using ATtuing.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATtuing.BackWeb.Areas.SystemManage.Controllers
{
    public class RoleController : BaseController
    {
        public IRoleService RoleService { get; set; }
        /// <summary>
        /// 角色管理页面
        /// </summary>
        /// <returns></returns>
        //public ActionResult Index()
        //{
        //  // var xx= RoleService.GetById(1);
        //    return View();
        //}
        [HttpPost]
        public ActionResult GetGridJson( Pagination pagination,string keyword= "")
        {
            //总记录条数
            pagination.records = RoleService.GetListCount(keyword);
            var data = new
            {
                records = pagination.records,
                rows = RoleService.GetList(keyword,pagination),
                total = pagination.total,
                page = pagination.page,
            };
            return Json(data);
        }

        public ActionResult AddRole() {
          //var xx=  RoleService.AddRole();
            return View();
        }
        /// <summary>
        /// 根据roleid获取角色信息
        /// </summary>
        /// <param name="keyValue">roleid</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult GetFormJson(decimal keyValue) {
            RoleDto role =  RoleService.GetRoleById(keyValue);
            return Json(role);
        }
        
        [HttpPost]
        public ActionResult SubmitForm(RoleModelDto role, decimal keyValue)
        {
            RoleService.AddRole( role,  keyValue);
            return Success("操作成功。");
        }
    }
}