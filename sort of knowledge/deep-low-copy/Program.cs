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
            /*
            CTS CLS CLR

                .net 平台下不只有C#语言，还有vb。net，F#等语言IL是程序最终编译的可以执行 的二进制代码（托管代码）；这样
                C#可以调用VB.net写的程序集（assembly，dll，exe）。在。net平台下：不同语言之间可以互联互通，互相调用
            不同语言的数据类型各个不同，比如整数类型vb。net中的integer，C#中的int。net平台规定了通用的数据类型(CTS,Common Type System),
            各个语言编译器把自己的语言类型翻译成CTS中的类型，int是C#中的类型，int32是CTS的类型
            string 和 String的区别是什么

            CLS 解决不同语言语法问题 ，进行统一规范

            CLR GC自动回收内存，没有被对象引用可以被释放了 gc是释放堆内存的 因为栈内存是自动释放的
            person p1=new Person();
            Person p2=p1;
            p2=null;
            p1=new Person();
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

