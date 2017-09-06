using ATtuing.BackWeb.Jobs;
using ATtuing.CommonMVC;
using ATtuing.IService;
using ATtuing.Service;
using Autofac;
using Autofac.Integration.Mvc;
using Quartz;
using Quartz.Impl;
using Quartz.Spi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            // Mapper映射
            MapperConfiguration.Configure();
            // 全局路由配置
            FilterConfig.RegisterFilters(GlobalFilters.Filters);

            // 开启作业调度
            startQuartz();
            // 
            InitAutoFac();
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
        private void InitAutoFac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly).PropertiesAutowired();
            // 把当前程序集中的 Controller  都注册
            // 不要忘了.PropertiesAutowired()
            //  获取所有相关类库的程序集
            Assembly[] assemblies = new Assembly[] { Assembly.Load("ATtuing.Service") };
            builder.RegisterAssemblyTypes(assemblies)
            .Where(type => !type.IsAbstract && typeof(IServiceSupport).IsAssignableFrom(type))
            .AsImplementedInterfaces().PropertiesAutowired();
            var container = builder.Build();
            // 注册系统级别的 DependencyResolver ，这样当 MVC  框架创建 Controller  等对象的时候都是管 Autofac  要对象。
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));//!!!
        }
        }
    }