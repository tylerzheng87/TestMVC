using EFEntities;
using MVCEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEF.Controllers
{
    //项目只是存在合适的架构，没有最好的,架构不是设计出来的，而是演化出来的
    public class HomeController : Controller
    {
        // GET: Home这么写不太符合项目上轨道的//dto使用用来各个层之间传数据用的，viewmodel是dto得到数据如果满足chtml页面的要求就直接显示也无所谓
        //DTO保证了，返回的对象一定是个普通的对象，而不是和EF关联的对象，对DTO的任何操作也不会影响数据库，避免层之间耦合
        //如果不满足就用viewmodel
        //正常是 ui层+dal+bal+dto但通常小项目不用bal 可以简化成UI+Service就相当于 ui+DAL
        public ActionResult Index()
        {
            using (MyContext ctx = new MyContext())
            {
               MinZu minzu = new MinZu { Name="hanzu"};
                 ctx.Minzus.Add(minzu);
                 ctx.SaveChanges();
                
                var clz = ctx.Classes.First();
                var students=ctx.Students.Where(s => s.ClassId == clz.Id).ToList();
                // ViewBag.students = students;
                HomeIndexModel homeindex = new HomeIndexModel();
                homeindex.Classes = clz;
                homeindex.Students = students;

                return View(homeindex);
            }  
           
        }
    }
}