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
        public ActionResult F2(FormCollection fc)
        {
            string name = fc["name"];
            string age=fc["age"];
            return Content("name"+name+",age="+age);

        }
        public ActionResult F2Show()
        {
            return View();
        }
        [HttpPost]
        public ActionResult F3(string name,HttpPostedFileBase f1)
        {
            f1.SaveAs(Server.MapPath("~/"+f1.FileName));
            return Content("baomingchenggong"+name);
        }

        [HttpGet]
        public ActionResult F3()
        {

            return View();
        }
        public ActionResult ReadTemp()
        {
            TempData["code"] = "1234";
            return View();

        }
        public ActionResult TempData1()
        {
            string code = (string)TempData["code"];
            return Content("code=" + code);


        }
        public ActionResult F3Show()
        {
            List<Person> list = new List<Person>();
            list.Add(new Models.Person { Id = 1, Name = "wangz"});
            list.Add(new Models.Person { Id = 2, Name = "us" });
            list.Add(new Models.Person { Id = 3, Name = "en" });
            list.Add(new Models.Person { Id = 4, Name = "un" });
            return View(list);
        }
        public ActionResult DDL1()
        {
            List<Person> list = new List<Person>();
            list.Add(new Models.Person { Id = 1, Name = "wangz" });
            list.Add(new Models.Person { Id = 2, Name = "us" });
            list.Add(new Models.Person { Id = 3, Name = "en" });
            list.Add(new Models.Person { Id = 4, Name = "un" });

            List<SelectListItem> sliList = new List<SelectListItem>();
            foreach (var item in list)
            {
                SelectListItem listItem = new SelectListItem();
                listItem.Selected = (item.Id == 2);
                listItem.Text = item.Name;
                listItem.Value = item.Id.ToString();
                sliList.Add(listItem);
            }
            return View(sliList);

        }
    }
}