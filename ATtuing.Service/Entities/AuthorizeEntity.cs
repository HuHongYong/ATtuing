using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATtuing.Service.Entities
{
    public  class AuthorizeEntity
    {
        /// <summary>/// 自增ID/// </summary>public decimal ID{get;set;}/// <summary>/// 请求的路由格式如：SystemManage/Organize/Index/// </summary>public string URLNAME{get;set;}/// <summary>/// 对该权限的描述/// </summary>public string DESCRIPTION{get;set;}/// <summary>/// 当前菜单等级：一共有1，2，3，4/// </summary>public decimal GRADE{get;set;}/// <summary>/// 父级菜单/// </summary>public decimal PARENTID{get;set;}/// <summary>/// 权限创建时间/// </summary>public DateTime CREATEDATETIME{get;set;}/// <summary>/// 显示的小图标/// </summary>public string ICON{get;set;}/// <summary>/// 生成GUID，在菜单iframe中做data_Id唯一标识/// </summary>public string GUID{get;set;}/// <summary>/// 跳转类型：0为框架内部跳转，1为打开新页面/// </summary>public decimal SKIPTYPE{get;set;}/// <summary>/// 排序，从1开始/// </summary>public decimal SORTNUM{get;set;}/// <summary>/// 是否允许点击弹出下拉选项，只要指二级菜单，0不容许点击，1允许/// </summary>public decimal ISCLICK{get;set;}

        public virtual ICollection<RoleEntity> Roles { get; set; } = new List<RoleEntity>();
    }
}
