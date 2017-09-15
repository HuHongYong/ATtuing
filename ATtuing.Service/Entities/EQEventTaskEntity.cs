using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATtuing.Service.Entities
{
   public class EQEventTaskEntity
    {
        /// <summary>
/// 任务编码
/// </summary>
public string TASKID{get;set;}
/// <summary>
/// 事件编码
/// </summary>
public string EQID{get;set;}
/// <summary>
/// 任务类型
/// </summary>
public string TTYPE{get;set;}
/// <summary>
/// 创建时间
/// </summary>
public DateTime CTIME{get;set;}
/// <summary>
/// 状态(0未开始,1正在抽取,2完成,3异常)
/// </summary>
public string STATUS{get;set;}
/// <summary>
/// 开始时间
/// </summary>
public DateTime STIME{get;set;}
/// <summary>
/// 结束时间
/// </summary>
public DateTime ETIME{get;set;}
/// <summary>
/// 备注
/// </summary>
public string REMARK{get;set;}

        public virtual EQEventEntity EQEvent { get; set; } = new EQEventEntity();
    }
}
