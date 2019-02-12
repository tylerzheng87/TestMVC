using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFReady1
{
    class Program
    {
        static void Main(string[] args)
        {
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
            foreach (var p1 in list3)
            {
                Console.WriteLine(p1);
            }
            Console.ReadKey();

        }
    }
}
