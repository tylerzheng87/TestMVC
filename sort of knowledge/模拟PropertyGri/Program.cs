using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace 模拟PropertyGri
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Age = 18;
            p1.Name = "Tman";
            ShowObject(p1);
            Console.ReadKey();
        }


        static void ShowObject(object obj)
        {
            Type type = obj.GetType();
            PropertyInfo[] props = type.GetProperties();
            foreach (var prop in props)
            {
                if (prop.CanRead)
                {
                    string propName = prop.Name;
                    object value = prop.GetValue(obj);//获取obj对象的prop属性的值
                    Console.WriteLine(propName + "=" + value);
                }
            }
        }
    }
    class Person : Program
    {
        public Person()
        {

        }
        public Person(string name)
        {


        }
        [DisplayName("姓名")]
        public string Name { get; set; }
        public int Age { get; set; }
        [Obsolete]//意味着这个分方法不能用了或者成员已经过时
        public void SayHi()
        {
            Console.WriteLine("大家好,我是" + this.Name + "，我的年龄" + this.Age);
        }
    }
}
