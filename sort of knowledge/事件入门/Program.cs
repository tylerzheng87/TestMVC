using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 事件入门
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.OnBenMingNian += BMN;//  p1.OnBenmingNian=  p1.OnBenmingNian+BMN2;
            p1.OnBenMingNian -= BMN2;
            //加event不能让他指向null这就是event和委托的区别    p1.OnBenmingNian = null;
            p1.Age = 5;
            Console.WriteLine(p1.Age);
            p1.Age = 24;
            Console.WriteLine(p1.Age);
            p1.Age = 55;
            Console.WriteLine(p1.Age);
            p1.Age = 48;
            Console.WriteLine(p1.Age);
            Console.ReadKey();
        }

        private static void BMN2()
        {
            Console.WriteLine("22222222到了本命年了");
        }

        private static void BMN()
        {
            Console.WriteLine("到了本命年了");
        }
    }
}
