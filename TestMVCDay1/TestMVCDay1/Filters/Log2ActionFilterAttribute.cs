
using System;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace TestMVCDay1.Filters
{
    public class Log2ActionFilterAttribute : FilterAttribute, IActionFilter
    {
        void IActionFilter.OnActionExecuted(ActionExecutedContext filterContext)
        {
            string actionName = filterContext.ActionDescriptor.ActionName;
            string ctrlName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            string path = filterContext.HttpContext.Server.MapPath("~/log2.txt");
            File.AppendAllText(path, "执行了" + ctrlName + "." + actionName);
        }

        void IActionFilter.OnActionExecuting(ActionExecutingContext filterContext)
        {
            string actionName = filterContext.ActionDescriptor.ActionName;
            string ctrlName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            string path = filterContext.HttpContext.Server.MapPath("~/log2.txt");
            File.AppendAllText(path, "将要执行了" + ctrlName + "." + actionName);
        }
    }

}