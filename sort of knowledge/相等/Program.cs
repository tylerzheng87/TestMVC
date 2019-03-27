using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 相等
{
    class Program
    {
        static void Main(string[] args)
        {

            string t1 = "kingbo";
            string t2 = "kingbo";
            string t3 = "king" + "bo";
            string t5 = new string(new char[] { 'k', 'i', 'n', 'g', 'b', 'o' });
            Console.WriteLine(object.ReferenceEquals(t1, t2));
            Console.WriteLine(object.ReferenceEquals(t1, t3));//编译器优化
            Console.WriteLine(object.ReferenceEquals(t1, t5));//正常来说t1和t2应该是两个对象，但CLR帮我们做了处理因为字符串的长度以及内容是不变的，
            //CLR就重用了上面的字符串就可以了，所以s1和s2指向同一个对象


            Person p1 = new Person();
            p1.Name = "king";
            p1.Age = 10;

            Person p2 = p1;
            Person p3 = new Person();
            p3.Name = "king";
            p3.Age = 10;

            Person p4 = new Person();
            p4.Name = "king";
            p4.Age = 18;
            /*
            Console.WriteLine(object.ReferenceEquals(p1, p2));
            Console.WriteLine(object.ReferenceEquals(p1, p3));
            
            Console.ReadKey();
            */
            /*
           Console.WriteLine(p1==p2);
           Console.WriteLine(p1 == p3);
            */
            string s1 = "abc";
            string s2 = s1;
            string s3 = new String(new char[] { 'a', 'b', 'c' });
            //Console.WriteLine(object.ReferenceEquals(p1, p2));
            //Console.WriteLine(object.ReferenceEquals(p1, p3));

            //字符串由于override了Equals方法，内部进行内容比较
            //Console.WriteLine(s1 == s2);
            //Console.WriteLine(s1 == s3);
            //Console.ReadKey();
            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p1.Equals(p3));
            Console.WriteLine(p1.Equals(p4));
            Console.ReadKey();

        }
   }

   class Person
   {
       public string Name { get; set; }
       public int Age { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is Person))
            {
                return false;
            }
            else
            {

                Person that = (Person)obj;
                //if (this.Name==that.Name&&this.Age==that.Age)
                //{
                //    return true;

                //}
                //else
                //{
                //    return false;
                //}
                return this.Name == that.Name && this.Age == that.Age;
            }
        }

    }
}
