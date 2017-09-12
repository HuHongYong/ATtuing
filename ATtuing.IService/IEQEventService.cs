using ATtuing.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATtuing.IService
{
    public interface IEQEventService: IServiceSupport
    {
        EQEventDto GetById();
        EQEventDto GetByIdSql();
        //测试原生Include
        bool IncludeEQEvent();
        //一对多最佳测试
        EQEventTaskDto GetEQEventTask();
    }
}
