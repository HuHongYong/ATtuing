using ATtuing.Dto;
using ATtuing.Service.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATtuing.Service.AutoMapper
{
    class RoleModelProfile: Profile
    {
        public RoleModelProfile()
        {
            var map = CreateMap<RoleEntity, RoleModelDto>();
            map.ForMember(r => r.CreateDatetime, opt => opt.MapFrom(s => s.CREATEDATETIME));
            map.ForMember(r => r.Id, opt => opt.MapFrom(s => s.ID));
            map.ForMember(r => r.Isdelete, opt => opt.MapFrom(s => s.ISDELETED));
            map.ForMember(r => r.Remark, opt => opt.MapFrom(s => s.REMARK));
            map.ForMember(r => r.RoleName, opt => opt.MapFrom(s => s.ROLENAME));
           map.ForMember(r => r.AuthorizeIds, opt => opt.MapFrom(s => s.Authorizes.Select(m=>m.ID)));
        }
    }
}
