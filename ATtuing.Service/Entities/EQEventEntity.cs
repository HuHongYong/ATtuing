using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ATtuing.Service.Entities
{
    public class EQEventEntity
    {
/// <summary>
/// 地震编码
/// </summary>
public string EQID{get;set;}
/// <summary>
/// 地震名称
/// </summary>
public string EQNAME{get;set;}
/// <summary>
/// 参考位置
/// </summary>
public string EQPLACE{get;set;}
/// <summary>
/// 震级
/// </summary>
public decimal EQLEVEL{get;set;}
/// <summary>
/// 时间
/// </summary>
public DateTime EQTIME{get;set;}
/// <summary>
/// 经度
/// </summary>
public decimal LON{get;set;}
/// <summary>
/// 纬度
/// </summary>
public decimal LAT{get;set;}
/// <summary>
/// 深度
/// </summary>
public decimal DEPTH{get;set;}
/// <summary>
/// 类型(0测试 1正式)
/// </summary>
public string EQTYPE{get;set;}
/// <summary>
/// 创建时间
/// </summary>
public DateTime CTIME{get;set;}

public virtual ICollection<EQEventTaskEntity> EQEventTasks { get; set; } = new List<EQEventTaskEntity>();
    }
}