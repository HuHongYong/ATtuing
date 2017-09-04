using ATtuing.CommonMVC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATtuing.BackWeb
{
    public class FilterConfig
    {
        public static void RegisterFilters(GlobalFilterCollection filters)
        {
            filters.Add(new ATtuingExceptionFilter());
            filters.Add(new JsonNetActionFilter());
        }
    }
}