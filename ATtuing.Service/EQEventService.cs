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
    public class EQEventService : IEQEventService
    {
        public EQEventDto GetById()
        {
            using (MyDbContext ctx=new MyDbContext())
            {
               return ctx.EQEvents.ProjectTo<EQEventDto>().FirstOrDefault();
            }
        }
    }
}
