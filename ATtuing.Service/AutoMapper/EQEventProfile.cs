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
    public class EQEventProfile: Profile
    {
        public EQEventProfile() {
            var map=CreateMap<EQEventEntity, EQEventDto>();
            map.ForMember(d => d.EQId, opt => opt.MapFrom(s => s.EQID));
            map.ForMember(d => d.CTime, opt => opt.MapFrom(s => s.CTIME));
            map.ForMember(d => d.Depth, opt => opt.MapFrom(s => s.DEPTH));
            map.ForMember(d => d.EQLevel, opt => opt.MapFrom(s => s.EQLEVEL));
            map.ForMember(d => d.EQName, opt => opt.MapFrom(s => s.EQNAME));
            map.ForMember(d => d.EQPlace, opt => opt.MapFrom(s => s.EQPLACE));
            map.ForMember(d => d.EQTime, opt => opt.MapFrom(s => s.EQTIME));
            map.ForMember(d => d.EQType, opt => opt.MapFrom(s => s.EQTYPE));
            map.ForMember(d => d.Lat, opt => opt.MapFrom(s => s.LAT));
            map.ForMember(d => d.Lon, opt => opt.MapFrom(s => s.LON));
        }
    }
}
