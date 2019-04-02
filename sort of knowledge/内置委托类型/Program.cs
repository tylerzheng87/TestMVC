using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 内置委托类型
{
    class Program
    {
        static void Main(string[] args)
        {
            Del1 d1 = F1;
            Action d2 = F1;
            Action<int, string> d3 = F2;
            Func<int,int,bool> d4 = F3;
        }
        static void F1()
        {
            Console.WriteLine("F1");
            Console.ReadKey();

        }
        static void F2(int i,string s)
        {
            

        }
        static bool F3(int i, int s)
        {
            return i > s;
        }
    }
    delegate void Del1();
}
