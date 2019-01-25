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
            /*1.
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
                        */
            /*2  var sList = from item in list
                          select new SelectListItem { Selected = item.Id == 2, Text = item.Name, Value = item.Id.ToString() };
                          return View(sList);
                          */
            SelectList selList = new SelectList(list, "Id", "Name");
            ViewBag.selList = selList;

            return View();

        }
        public ActionResult AjaxTest()
        {
            Person p = new Person();
            p.Name = "zheng";
            //主流浏览器在发出ajax请求的时候都会带着
            //X -Requested-With:XMLHttpRequest报文头
            if (Request.IsAjaxRequest())
            {

                return Json(p);
            }
            else
            {
                return Content(p.Name);
            }

        }
        public ActionResult TypeHttpUrlTest()
        {
            return View();
        }

        //MVC 并不会在请求失败的时候抛异常，而是把决定权交给程序员
        public ActionResult Validate(Person person)
        {
            if (ModelState.IsValid)
            {
                return Content("Id=" + person.Id);
            }
            else
            {
                string msg = MVCHelper.GetValidMsg(ModelState);
                return Content("验证失败"+msg);
            }
          
        }
        //面向过程 if，for，函数
        //面向对象编程 继承
        //面向切面编程 理念（把一些公共的行为写到一个地方，省的每个地方都写同样的代码）

        //1.AAA()
 //       try 
	//{	        
	//	faafaf
	//}
	//catch (Exception)
	//{

	//	throw;
	//}
        //----->都是如何组织代码，结构更清晰
        //2.(global Application_Error)-------->Filler就是 AOP的思想的体现
    }
}