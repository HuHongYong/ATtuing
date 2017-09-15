using ATtuing.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATtuing.IService
{
    public interface IAuthorizeService:IServiceSupport
    {
        List<AuthorizeDto> GetAll();
    }
}
