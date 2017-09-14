using ATtuing.Service.AutoMapper;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATtuing.Service
{
   public class MapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<EQEventProfile>();
                cfg.AddProfile<EQEventTaskProfile>();
                cfg.AddProfile<RoleProfile>();
                cfg.AddProfile<RoleModelProfile>();
            });
        }
    }
}
