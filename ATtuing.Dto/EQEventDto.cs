using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ATtuing.Dto
{
    public class EQEventDto
    {
/// <summary>
/// 地震编码
/// </summary>
public string EQId{get;set;}
/// <summary>
/// 地震名称
/// </summary>
public string EQName{get;set;}
/// <summary>
/// 参考位置
/// </summary>
public string EQPlace{get;set;}
/// <summary>
/// 震级
/// </summary>
public decimal EQLevel{get;set;}
/// <summary>
/// 时间
/// </summary>
public DateTime EQTime{get;set;}
/// <summary>
/// 经度
/// </summary>
public decimal Lon{get;set;}
/// <summary>
/// 纬度
/// </summary>
public decimal Lat{get;set;}
/// <summary>
/// 深度
/// </summary>
public decimal Depth{get;set;}
/// <summary>
/// 类型(0测试 1正式)
/// </summary>
public string EQType{get;set;}
/// <summary>
/// 创建时间
/// </summary>
public DateTime CTime{get;set;}
        /// <summary>
        /// 创建时间
        /// </summary>
        public List<string> TaskIds { get; set; } = new List<string>();
    }
}