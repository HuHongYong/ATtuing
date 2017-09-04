using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATtuing.BackWeb
{
    public class ATtuingExceptionFilter : IExceptionFilter
    {
        private static ILog log = LogManager.GetLogger(typeof(ATtuingExceptionFilter));
        public void OnException(ExceptionContext filterContext)
        {
            log.Error("出现未处理异常", filterContext.Exception);
        }
    }
}