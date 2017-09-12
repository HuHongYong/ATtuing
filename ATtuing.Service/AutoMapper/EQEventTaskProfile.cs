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
  public  class EQEventTaskProfile : Profile
    {
        public EQEventTaskProfile()
        {
            var map = CreateMap<EQEventTaskEntity, EQEventTaskDto>();
            map.ForMember(d => d.TaskId, opt => opt.MapFrom(s => s.TASKID));
            map.ForMember(d => d.EQName, opt => opt.MapFrom(s => s.EQEvent.EQNAME));
        }
    }
}