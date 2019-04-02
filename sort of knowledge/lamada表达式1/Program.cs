using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lamada表达式1
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> a1 = delegate (int i)
            {

                Console.WriteLine(i);
            };
                a1(3);
            //lambda表达式格式的匿名写法的 lambda表达式是帮助我们简化匿名函数的写法
            Action<int> a2 = (int i) => { Console.WriteLine(i); };
            a2(666);
            Action<int> a3 = (i) => { Console.WriteLine(i); };
            a3(888);
            //只有一个参数小括号也能省略
            Action<int> a4 =i=> { Console.WriteLine(i); };
            a3(888);
            Func<string, int, bool> f1 = delegate (string s, int i) { return true; };
            Func<string, int, bool> f2 =  (string s, int i)=> { return true; };
            Func<string, int, bool> f3 = ( s,  i) => { return true; };

            Func<string, int, bool> f4 = (s, i) =>  true;//如果方法有返回值，可以连大括号return 省略

            Console.ReadKey();
            }
        
    }
}
