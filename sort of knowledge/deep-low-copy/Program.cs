using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deep_low_copy
{
    class Program
    {
        static void Main(string[] args)
        {
            /*     Person p1 = new Person();
                 p1.Name = "tman";
                 p1.Age = 340;
                 // Person p2 = p1;//让p2指向的p1当前所指向对象

                 //拷贝克隆 Clone
                 Person p2 = new Person();//拷贝一份出来
                 p2.Name = p1.Name;
                 p2.Age = p1.Age;
                 p1.Age = 666;
                 Console.WriteLine(p2.Age);
                 */
          /*  Dog d1 = new Dog();
            d1.Name = "wangcai";
            Person p1 = new Person();
            p1.Name = "tman";
            p1.Age = 340;
            p1.Dog = d1;

            Person p2 = new Person();
            p2.Name = p1.Name;
            p2.Age = p1.Age;
            p2.Dog = p1.Dog;

            //对象还是引用同一份,浅拷贝
            p1.Dog.Name = "八戒";

            Console.WriteLine(p2.Dog.Name);
            Console.ReadKey();
            */


            Dog d1 = new Dog();
            d1.Name = "wangcai";
            Person p1 = new Person();
            p1.Name = "tman";
            p1.Age = 340;
            p1.Dog = d1;

            Person p2 = new Person();
            p2.Name = p1.Name;
            p2.Age = p1.Age;
            Dog d2 = new Dog();
            d2.Name = p1.Dog.Name;

            p2.Dog = d2;
            //对象也是是拷贝一份,深拷贝
            p1.Dog.Name = "八戒";

            Console.WriteLine(p2.Dog.Name);
            Console.ReadKey();
        }

    }

    class Dog
    {

        public string Name { get; set; }
        public int Age { get; set; }

    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Dog Dog { get; set; }

    }
}

