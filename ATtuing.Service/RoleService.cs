using ATtuing.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATtuing.Dto;
using System.Data.Entity;
using AutoMapper.QueryableExtensions;
using ATtuing.Service.Entities;
using ATtuing.Common;

namespace ATtuing.Service
{
    public class RoleService : IRoleService
    {
        public void AddRole(RoleModelDto model, decimal roleId)
        {
            using (MyDbContext ctx = new MyDbContext())
            {
                if (roleId!=0)
                {
                   RoleEntity temprole= ctx.Roles.SingleOrDefault(r=>r.ID==roleId);
                    temprole.REMARK = model.Remark;
                    temprole.ROLENAME = model.RoleName;
                    var authorizes = ctx.Authorizes.Where(a => model.AuthorizeIds.Contains(a.ID)).ToArray();
                    foreach (var item in authorizes)
                    {
                        temprole.Authorizes.Add(item);
                    }
                    ctx.Entry(temprole).State = System.Data.Entity.EntityState.Unchanged;
                    int x = ctx.SaveChanges();

                }
                //多对多添加时
                // RoleEntity role = new RoleEntity();
                // role.ISDELETED = 1;
                // role.REMARK = "测试用户";
                // role.ROLENAME = "测试用户";
                // role.CREATEDATETIME = DateTime.Now;
                // decimal[] authorizeids = new decimal[] { 100248, 100250 };
                //var authorizes= ctx.Authorizes.Where(a => authorizeids.Contains(a.ID)).ToArray();
                // foreach (var item in authorizes)
                // {
                //     role.Authorizes.Add(item);
                // }
                // ctx.Roles.Add(role);
                // int x=ctx.SaveChanges();
            }
        }

        public RoleModelDto GetById(decimal id)
        {
            using (MyDbContext ctx=new MyDbContext())
            {
              return  ctx.Roles.ProjectTo<RoleModelDto>().SingleOrDefault(r=>r.Id==id);
            }
        }

        public List<RoleDto> GetList(string keyword, Pagination pagination)
        {
            using (MyDbContext ctx = new MyDbContext())
            {
                return ctx.Roles.ProjectTo<RoleDto>().Where(r=>r.RoleName.Contains(keyword)) .OrderByDescending(h => h.CreateDatetime)
                    .Skip((pagination.page-1)* pagination.rows).Take(pagination.rows).ToList();
            }
        }

        public long GetListCount(string keyword)
        {
            using (MyDbContext ctx = new MyDbContext())
            {
                return ctx.Roles.LongCount(r => r.ROLENAME.Contains(keyword));
            }
        }

        public RoleDto GetRoleById(decimal id)
        {
            using (MyDbContext ctx = new MyDbContext())
            {
                return ctx.Roles.ProjectTo<RoleDto>().SingleOrDefault(r => r.Id == id);
            }
        }
    }
}
