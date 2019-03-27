using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refout
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "king";
            int i = 5;
            // Test(p, i
            //Test2(ref p,ref i);
            //Console.WriteLine(p.Name);
            //Console.WriteLine(i);
            //Console.ReadKey();
          
            //ref 使用的时候传参的时候必须给变量赋值，必须写ref
            int i1 = 5; int i2 = 6;
            // Swap(i1, i2);
            Swap2(ref i1, ref i2);

            //out 返回多个返回值使用之前不需要被赋值
            Test3(out i,out i1);
            Console.WriteLine("i=" + i + ",i2=" + i1);
            Console.WriteLine("i1=" + i1 + ",i2=" + i2);
            string s = "sdf";
            //string s = "123";
            //   int c = int.Parse(s);
            // int d = Convert.ToInt32(s);
            //Console.WriteLine("c=" + c + ",d=" + d);
            //Console.ReadKey();
            if (int.TryParse(s,out i))
            {
                Console.WriteLine("i" + i);
            }
            else
            {
                Console.WriteLine("不是合法整数");
                Console.ReadKey();
            }
           
          

        }

        static void Test(Person p,int i)
        {
            //p.Name = "haha";
            //i = 666;
            //Console.WriteLine(i);
            //Console.ReadKey();
          
            //  Console.WriteLine(i);


        }
        //ref就相当于把外部的变量传进来了，在函数内部可以改变外部变量的指向
        static void Test2(ref Person p, ref int i)
        {
            //p.Name = "haha";
            //i = 666;
            //Console.WriteLine(i);
            //Console.ReadKey();
            p = new Person();
            p.Name = "haha";
            Console.WriteLine(i);


        }
        static void Test3(out int i, out int i1)
        {
            i = 6;
            i1 = 999;

        }
        static void Swap(int i1, int i2)
        {

            int tem = i1;
            i1 = i2;
            i2 = tem;
        }
        static void Swap2(ref int i1, ref int i2)
        {

            int tem = i1;
            i1 = i2;
            i2 = tem;
        }
        class Person
        {
            public string Name { get; set; }

        }
    }
}
