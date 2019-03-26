using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 结构体
{
    class Program
    {
        static void Main(string[] args)
        {
            //什么事“引用类型”：引用类型派生自System.object
            //什么事“值类型”：值类型均隐式派生System.ValueType(ValueType其实也是继承自Object,不过是特例独行的分支)
            //值类型有哪些：数值类型（int，longdouble，float，char），bool，结构体，枚举（怎么看不到int32继承自valuetype编译器完成的）
            //引用的类型有哪些字符串，数组，类，接口等
            /*
            Person p1 = new Person();
            p1.Name = "tman";
            p1.Age = 1;
            Person p2 = p1;//类则是指向同一个引用
            p1.Age = 666;
            Console.WriteLine(p2.Age);
            Console.ReadKey();
            */
            //区别：引用类型变量的赋值只复制对象的引用，拷贝的是引用：引用类型在堆内存(malloc；值类型变量赋值会拷贝一个副本；值类型在栈内存；值类型一定是sealed；
            /*
           Dog d1 = new Dog();
           d1.Name = "tman";
           d1.Age = 1;
           Dog d2 = d1;//是根据p1的内容拷贝了一份出来
           d1.Age = 666;
           Console.WriteLine(d2.Age);
           Console.ReadKey();

     */
            int[] nums = { 3, 5, 6 };
            test(nums);
            Console.WriteLine(nums[1]);
            Console.ReadKey();
        }

         static void test(int[] nums)
        {
            nums[1] = 6666;
        }
    }

   class Person
   {
        public string Name { get; set; }
       public int Age { get; set; }
   }
   struct Dog
   {
       public string Name { get; set; }
       public int Age { get; set; }

   }
}
