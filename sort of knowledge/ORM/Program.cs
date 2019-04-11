using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public  class Program
    {
        static void Main(string[] args)
        {
            //最早访问数据库用ADO.net，程序要要掌握SQL 语句，ORM：EF（entity framework,Dapper,Nhibernate）
            //ORM:EF(entity framework,Dapper,Nhibernate)
            /*   Person p1 = new Person();
               p1.Name = "Tman";
               p1.Age = 7;
               ORM.Insert(p1);
               */
            Person p1 = (Person)ORM.SelectById(typeof(Person),1);
            Console.WriteLine(p1.Name);
        }
    }
}
