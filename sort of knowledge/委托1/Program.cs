using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //delegate void MyDel(int n):定一个类型MyDel，MyDel这个类型的变量可以指向一个“返回值为void”,参数为int的方法
            //delegate 是数据类型就像Class一样,一切都是对象，委托就是把方法当成对象看的东西
            //不能写成new MyDel(M1());
            //因为()代表调用方法
            MyDel d1 = new MyDel(M1);//声明一个Mydel类型的变量d1，new mydel(M1)创建一个指向M1方法的委托对象
            d1(5);
            Console.ReadKey();
        }
        static void M1(int a)
        {
            Console.WriteLine("M1" + a);
        }
    }
    delegate int MyDell(string s,string s1);
}
