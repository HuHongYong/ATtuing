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

namespace ATtuing.Service
{
    public class RoleService : IRoleService
    {
        public bool AddRole()
        {
            using (MyDbContext ctx = new MyDbContext())
            {
                //多对多添加时
                RoleEntity role = new RoleEntity();
                role.ISDELETED = 1;
                role.REMARK = "测试用户";
                role.ROLENAME = "测试用户";
                role.CREATEDATETIME = DateTime.Now;
                decimal[] authorizeids = new decimal[] { 100248, 100250 };
               var authorizes= ctx.Authorizes.Where(a => authorizeids.Contains(a.ID)).ToArray();
                foreach (var item in authorizes)
                {
                    role.Authorizes.Add(item);
                }
                ctx.Roles.Add(role);
                int x=ctx.SaveChanges();
                if (x==0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public RoleModelDto GetById(decimal id)
        {
            using (MyDbContext ctx=new MyDbContext())
            {
              return  ctx.Roles.ProjectTo<RoleModelDto>().SingleOrDefault(r=>r.Id==id);
            }
        }
    }
}
