using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace 对象浅拷贝
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Tman";
            p1.Age = 6;
            p1.Id = 999;

            Person p2 = new Person();
            p2.Name = p1.Name;
            p2.Age = p1.Age;
            p2.Id = p1.Id;


            Person p3 = (Person)MyClone(p1);
            p3.SayHi();
            Console.WriteLine(object.ReferenceEquals(p1, p3));
            Console.ReadKey();
        }
        static object MyClone(object obj)
        {
            Type type = obj.GetType();
            object newObj = Activator.CreateInstance(type);//创建一个拷贝对象
            foreach (PropertyInfo prop in type.GetProperties())
            {

                if (prop.CanRead&&prop.CanWrite)
                {
                    object value = prop.GetValue(obj);//获取obj对象的属性值
                    prop.SetValue(newObj, value);//把值赋值给newObj对应的属性
                }
            }
            return newObj;
        }
    }
    class Person : Program
    {
        public Person()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public void SayHi()
        {
            Console.WriteLine("大家好,我是" + this.Name + "，我的年龄" + this.Age);
        }
    }
}
