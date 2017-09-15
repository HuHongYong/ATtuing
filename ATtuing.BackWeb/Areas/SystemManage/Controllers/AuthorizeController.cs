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
    public class AuthorizeController : Controller
    {
        public IAuthorizeService AuthorizeService { get; set; }
        public IRoleService RoleService { get; set; }
        // GET: SystemManage/Authorize
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 通过角色获取权限展示拥有或无
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        public ActionResult GetAuthorizeTree(decimal roleId) {
            var treeList = GetTree(roleId);
            return Content(TreeView.TreeViewJson(treeList));
        }
        public List<TreeViewModel> GetTree(decimal roleId)
        {
            var mods = RoleService.GetById( roleId);
            List<TreeViewModel> treeList = new List<TreeViewModel>();
            List<AuthorizeDto> listAnthorize = AuthorizeService.GetAll();
            foreach (var item in listAnthorize)
            {
                TreeViewModel treeuser = new TreeViewModel();
                treeuser.id = item.Id.ToString();
                treeuser.showcheck = true;
                treeuser.text = item.Description;
                treeuser.img = item.Icon;
                treeuser.parentId = item.ParentId.ToString();
                bool hasChildren = listAnthorize.Count(t => t.ParentId == item.Id) == 0 ? false : true;
                treeuser.isexpand = true;
                treeuser.checkstate = mods.AuthorizeIds.Contains(item.Id)?1:0;
                treeuser.complete = true;
                treeuser.hasChildren = hasChildren;
                treeList.Add(treeuser);
            }
            return treeList;
        }
    }
}