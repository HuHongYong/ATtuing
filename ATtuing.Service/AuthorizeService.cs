using ATtuing.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATtuing.Dto;
using AutoMapper.QueryableExtensions;

namespace ATtuing.Service
{
    public class AuthorizeService : IAuthorizeService
    {
        public List<AuthorizeDto> GetAll()
        {
            using (MyDbContext ctx = new MyDbContext())
            {
                return ctx.Authorizes.ProjectTo<AuthorizeDto>().ToList();
            }
        }
    }
}
