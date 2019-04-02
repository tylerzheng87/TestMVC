using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 匿名方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Mydel d1 = delegate (int i1, string s1)
              {
                  Console.WriteLine("我是匿名方法" + i1 + s1);
                  return true;
              };
            bool b1 = d1(5, "Tyler");
            Console.WriteLine(b1);
            Console.ReadKey();

        }
        static bool F1(int i, string str)
        {
            Console.WriteLine("i=" + i + ",str" + str);
            return false;

        }
    }
    delegate bool Mydel(int i, string s);
}
