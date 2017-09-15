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
   public class AuthorizeProfile: Profile
    {
        public AuthorizeProfile() {
            var map = CreateMap<AuthorizeEntity, AuthorizeDto>();
            map.ForMember(d => d.CreateDatetime, opt => opt.MapFrom(s => s.CREATEDATETIME));
            map.ForMember(d => d.Description, opt => opt.MapFrom(s => s.DESCRIPTION));
            map.ForMember(d => d.Grade, opt => opt.MapFrom(s => s.GRADE));
            map.ForMember(d => d.Guid, opt => opt.MapFrom(s => s.GUID));
            map.ForMember(d => d.Icon, opt => opt.MapFrom(s => s.ICON));
            map.ForMember(d => d.Id, opt => opt.MapFrom(s => s.ID));
            map.ForMember(d => d.Isclick, opt => opt.MapFrom(s => s.ISCLICK));
            map.ForMember(d => d.ParentId, opt => opt.MapFrom(s => s.PARENTID));
            map.ForMember(d => d.SkipType, opt => opt.MapFrom(s => s.SKIPTYPE));
            map.ForMember(d => d.Sortnum, opt => opt.MapFrom(s => s.SORTNUM));
        }
    }
}
