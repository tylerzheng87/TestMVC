using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFReady1
{
    //ORM 通俗的说就是用操作对象的方式来操作数据库，不用自己写Sql
    //ORM工具有很多 Dapper，PetaPoco，Nhibernate，EF底层仍然是ADO.net
    //EF DataAnnotations,FluentAPI两种配置方式，DataAnnotations方式比较方便，[Table("T_Persons")],[Column("Name")]
    //但耦合度比较高，不太符合大项目开发的要求，微软推荐使用FlentAPI的方式,一般类最好是POCO（plain old C# object 没有继承什么特殊的父类，没有标注什么特殊的Atrribute
    //没有定义什么太特殊的方法,就是一堆普通的属性）
    class Program
    {
        static void Main(string[] args)
        {
            //linqtest
            //lamda 对linq 说论漂亮我不行 论强大你不行
            Master m1 = new Master { Id = 1, Name = "tw" };
            Master m2 = new Master { Id = 2, Name = "bill" };
            Master m3 = new Master { Id = 3, Name = "zxc" };
            Master[] masters = { m1, m2, m3 };

            Dog d1 = new Dog { Id = 1, MasterId = 3, Name = "旺财" };
            Dog d2 = new Dog { Id = 2, MasterId = 3, Name = "旺旺" };
            Dog d3 = new Dog { Id = 3, MasterId = 1, Name = "京巴" };
            Dog d4 = new Dog { Id = 4, MasterId = 2, Name = "泰迪" };
            Dog d5 = new Dog { Id = 5, MasterId = 1, Name = "中华田园" };
            Dog[] dogs = { d1, d2, d3, d4, d5 };

            var result1 = dogs.Where(d =>d.Id>=1).Join(masters, d =>d.MasterId, m=>m.Id,(d,m) => new { DogName = d.Name, MasterName = m.Name });
            foreach (var item in result1)
            {
                Console.WriteLine(item.DogName + "," + item.MasterName);
            }

            var s0 = new Person { Name = "tom", Age = 3, Gender = true, Salary = 100 };
            var s1 = new Person { Name = "zoe", Age = 3, Gender = false, Salary = 1000 };
            var s2 = new Person { Name = "kim", Age = 44, Gender = true, Salary = 500 };
            var s3 = new Person { Name = "nancy", Age = 33, Gender = false, Salary = 700 };
            var s4 = new Person { Name = "cheni", Age = 33, Gender = true, Salary = 5600 };
            var s5 = new Person { Name = "veni", Age = 11, Gender = false, Salary = 200 };
           
            List<Person> list = new List<Person>();
            list.Add(s0);
            list.Add(s1);
            list.Add(s2);
            list.Add(s3);
            list.Add(s4);
            list.Add(s5);
            Teacher t1 = new Teacher { Name = "tw" };
            t1.Students.Add(s1);
            t1.Students.Add(s2);
            Teacher t2 = new Teacher { Name = "jt" };
            t2.Students.Add(s2);
            t2.Students.Add(s3);
            t2.Students.Add(s5);
            Teacher[] teachers = { t1, t2 };

            int[] nums1 = { 3, 5, 8, 11, 15 };
            int[] nums2 = { 5, 7, 8, 9, 15 };

            //  var nums3 = nums1.Except(nums2);
           //  var nums3 = nums1.Union(nums2);
            //foreach (int i in nums3)
            //{
            //    Console.WriteLine(i);
            //}
            var items = list.GroupBy(g => g.Age);
            foreach (var item in items)
            {
                Console.WriteLine("key=" + item.Key + ",avg=" + item.Average(p => p.Salary) + ",max=" + item.Max(p => p.Salary));
            }

            foreach (var s in teachers.SelectMany(t=>t.Students))
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(teachers.Any());
            List<int> list1 = new List<int>();
            Console.WriteLine(list1.Any());
            Console.WriteLine(teachers.Any(t=>t.Name== "jt"));
            //   var list2=  list.OrderBy(p => p.Age);
            // var list2 = list.OrderByDescending(p => p.Age);
            // var list2 = list.OrderBy(p => p.Age).OrderBy(p => p.Salary); ;
            //var list2 = list.OrderBy(p => p.Age).ThenBy(p => p.Salary);
            //foreach (Person p1 in list2)
            //{
            //    Console.WriteLine(p1);
            //}

            var list3 = list.Skip(2).Take(1);
            //C# 6.0 新语法 nameof   为了解决类似compare方法比较式无法比较变量带来的编译错误，有他变量名错了就会编译不过去。
            string nameofstring="name"  ;
            int? i = 5;
             int j = i ?? 3;
            //6.0之前这么写 int j = (i == null ? 3 : (int)i);
            string s8 = null;
            string s9 = s8?.Trim();
            //6.0之前这么写 string s9=(s8==null?null:s8.Trim());
            //string s9=s8.Trim();
            foreach (var p1 in list3)
            {
                Console.WriteLine(p1);
                Console.WriteLine(nameof(nameofstring));
                Console.WriteLine(j);
                Console.WriteLine(s9==null);
            }

            using (TestDbContext ctx = new TestDbContext())
            {
                PersonEF p2 = new PersonEF();
                p2.CreateDateTime = DateTime.Now;
                p2.Name = "rupeng.com";
                ctx.PersonEF.Add(p2);
                ctx.SaveChanges();

            }
                Console.ReadKey();

        }
    }
}
