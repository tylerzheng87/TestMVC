using System;
using System.Web.Mvc;

namespace TestMVCDay1.Filters
{
    public class CheckLoginFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            string ctrlName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            string actionName = filterContext.ActionDescriptor.ActionName;
            if (ctrlName=="Login"&&(actionName=="Index"||actionName=="Login"))
            {
                //什么都不做
            }
            else
            {
                //检查登陆状态
                if (filterContext.HttpContext.Session["username"] == null)
                {
                    ContentResult contentResult = new ContentResult();
                    contentResult.Content = "没有登陆";
                    //如果在Filter中给filterContex.Result 赋值了,那么将不再继续执行要执行的Filter
                    //而是把filterContex.Result执行，返回给用户
                    //filterContext.Result = contentResult;阻止action执行
                    //这种写法不好老版本要执行一遍index，现在微软已经修复filterContext.HttpContext.Response.Redirect("/Login/Index");
                    //推荐使用filterContext.Result=new Redirectio
                    //filterContext.Result = new RedirectResult("/Login/Index");
                }
            }
        }
    }
}