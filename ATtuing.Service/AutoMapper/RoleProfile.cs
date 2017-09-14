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
  public  class RoleProfile: Profile
    {
        public RoleProfile() {
            var map = CreateMap<RoleEntity, RoleDto>();
            map.ForMember(r => r.CreateDatetime, opt => opt.MapFrom(s => s.CREATEDATETIME));
            map.ForMember(r => r.Id, opt => opt.MapFrom(s => s.ID));
            map.ForMember(r => r.Isdelete, opt => opt.MapFrom(s => s.ISDELETED));
            map.ForMember(r => r.Remark, opt => opt.MapFrom(s => s.REMARK));
            map.ForMember(r => r.RoleName, opt => opt.MapFrom(s => s.ROLENAME));
        }
    }
}
