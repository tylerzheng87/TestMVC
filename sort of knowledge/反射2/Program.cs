using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace 反射2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type t1 = typeof(Person);
            //Type t2 = t1.BaseType;
            //Console.WriteLine(t2);
            //Type t1type = t1.GetType();
            //Console.WriteLine(t1type.BaseType.BaseType);
            Type type = typeof(Person);
            object obj = Activator.CreateInstance(type);//new Person();
            PropertyInfo proName = type.GetProperty("Name");
            proName.SetValue(obj,"Tman");
            MethodInfo methodSayHi = type.GetMethod("SayHi", new Type[0]);
            methodSayHi.Invoke(obj, new object[0]);
            //ConstructorInfo c1 = t1.GetConstructor(new Type[0]);
            //ConstructorInfo c2 = t1.GetConstructor(new Type[] { typeof(string)});
            //ConstructorInfo c3 = t1.GetConstructor(new Type[] { typeof(int),typeof(string)});
            ////public object Invoke(object[] parameters);
            //MethodInfo m1 = t1.GetMethod("SayHi");
            //Console.WriteLine(c1);
            Console.ReadKey();
        }
    }

    class Person :Program
    {
        public Person()
        {
        
        }
        public Person(string name)
        {


        }
        public string Name { get; set; }
        public int Age { get; set; }
        public void SayHi()
        {
            Console.WriteLine("大家好,我是"+this.Name+"，我的年龄"+this.Age);
        }
    }
}
