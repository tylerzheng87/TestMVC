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
