using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATtuing.Dto
{
   public class AuthorizeDto
    {
            /// <summary>/// 自增ID/// </summary>public decimal Id{get;set;}/// <summary>/// 请求的路由格式如：SystemManage/Organize/Index/// </summary>public string UrlName{get;set;}/// <summary>/// 对该权限的描述/// </summary>public string Description{get;set;}/// <summary>/// 当前菜单等级：一共有1，2，3，4/// </summary>public decimal Grade{get;set;}/// <summary>/// 父级菜单/// </summary>public decimal ParentId{get;set;}/// <summary>/// 权限创建时间/// </summary>public DateTime CreateDatetime{get;set;}/// <summary>/// 显示的小图标/// </summary>public string Icon{get;set;}/// <summary>/// 生成GUID，在菜单iframe中做data_Id唯一标识/// </summary>public string Guid{get;set;}/// <summary>/// 跳转类型：0为框架内部跳转，1为打开新页面/// </summary>public decimal SkipType{get;set;}/// <summary>/// 排序，从1开始/// </summary>public decimal Sortnum{get;set;}/// <summary>/// 是否允许点击弹出下拉选项，只要指二级菜单，0不容许点击，1允许/// </summary>public decimal Isclick{get;set;}
    }
}
