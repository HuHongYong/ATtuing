using ATtuing.BackWeb.Jobs;
using ATtuing.CommonMVC;
using Quartz;
using Quartz.Impl;
using Quartz.Spi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ATtuing.BackWeb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //全半角转换
            ModelBinders.Binders.Add(typeof(string), new TrimToDBCModelBinder());
            ModelBinders.Binders.Add(typeof(int), new TrimToDBCModelBinder());
            ModelBinders.Binders.Add(typeof(long), new TrimToDBCModelBinder());
            ModelBinders.Binders.Add(typeof(double), new TrimToDBCModelBinder());

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            log4net.Config.XmlConfigurator.Configure();


            // 全局路由配置
            FilterConfig.RegisterFilters(GlobalFilters.Filters);

            // 开启作业调度
            startQuartz();
        }
            private void startQuartz()
            {
                IScheduler sched = new StdSchedulerFactory().GetScheduler();

                //给老板的报表开始
                JobDetailImpl jdBossReport
                    = new JobDetailImpl("jdBossReport", typeof(BossReportJob));
                IMutableTrigger triggerBossReport
                    = CronScheduleBuilder.DailyAtHourAndMinute(14, 47).Build();//每天23:45执行一次
                triggerBossReport.Key = new TriggerKey("triggerBossReport");
                sched.ScheduleJob(jdBossReport, triggerBossReport);
                //给老板的报表结束


                sched.Start();

            }
        }
    }