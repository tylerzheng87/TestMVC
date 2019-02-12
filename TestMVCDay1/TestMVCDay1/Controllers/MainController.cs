using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVCDay1.Filters;

namespace TestMVCDay1.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        [Log2ActionFilter]
        public ActionResult Index()
        {
            //if (Session["username"]==null)
            //{
            //    return Content("没有权限");
            //}
            return Content("Index出来喽！！！" + Session["username"]);
        }
        public ActionResult ZZ()
        {
            return Content("开始转账！！！");
        }
    }
}