using ATtuing.Common;
using ATtuing.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATtuing.IService
{
   public interface IRoleService : IServiceSupport
    {
        RoleModelDto GetById(decimal id);
        RoleDto GetRoleById(decimal id);
        //分页获取数据
        List<RoleDto> GetList(string keyword, Pagination pagination);
        //获取数据总条数
        long GetListCount(string keyword);
        void AddRole(RoleModelDto model,decimal roleId);
    }
}
