using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATtuing.Dto
{
   public  class RoleModelDto
    {
        /// <summary>/// 角色名称/// </summary>public string RoleName{get;set;}/// <summary>/// 角色说明/// </summary>public string Remark{get;set;}/// <summary>/// 自增ID/// </summary>public decimal Id{get;set;}/// <summary>/// 角色创建时间/// </summary>public DateTime CreateDatetime{get;set;}/// <summary>/// 角色状态，0删除，1正常/// </summary>public decimal Isdelete{get;set;}

        public List<decimal> AuthorizeIds { get; set; } = new List<decimal>();

    }
}
