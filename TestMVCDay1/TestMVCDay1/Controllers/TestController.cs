using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVCDay1.Models;

namespace TestMVCDay1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index(IndexModel model)
        {
            model.Result = model.Num1 + model.Num2;
            return View(model);
        }
    }
}