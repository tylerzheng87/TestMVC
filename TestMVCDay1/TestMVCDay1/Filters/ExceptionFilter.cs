using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestMVCDay1.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        void IExceptionFilter.OnException(ExceptionContext filterContext)
        {
            Exception ex = filterContext.Exception;
            string path = filterContext.HttpContext.Server.MapPath("~/error.txt");
            filterContext.ExceptionHandled = true;//如果有其他的IExceptionFilter不再执行
            File.AppendAllText(path, "执行了" + ex.ToString()+"\n");
        }
    }
}       