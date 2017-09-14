using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATtuing.Service.Entities
{
   public class RoleEntity
    {
        /// <summary>/// 角色名称/// </summary>public string ROLENAME{get;set;}/// <summary>/// 角色说明/// </summary>public string REMARK{get;set;}/// <summary>/// 自增ID/// </summary>public decimal ID{get;set;}/// <summary>/// 角色创建时间/// </summary>public DateTime CREATEDATETIME{get;set;}/// <summary>/// 角色状态，0删除，1正常/// </summary>public decimal ISDELETED{get;set;}
        /// <summary>
        /// 对应关系
        /// </summary>
        public virtual ICollection<AuthorizeEntity> Authorizes { get; set; } = new List<AuthorizeEntity>();

    }
}
