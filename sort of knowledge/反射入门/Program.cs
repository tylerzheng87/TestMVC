using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 反射入门
{
    class Program
    {
        //为什么vs把鼠标放到一个变量上值就能显示出来就是通过反射搞出来的，比如说写程序的时候new一个对象付了一些值之外
        //暂时不用为了以后用通过序列化的方式保存的一个文件里面，想用的时候把它读取出来读取成一个对象，都是用到了反射来实现的
        //反射可以动态创建对象动态赋值动态调用方法，最大的好处是开发人员也许都不知道要执行什么。
        //.Net中类都是被编译成IL，反射就可以在运行时获得类的信息（有哪些字段方法父类等等）还可以动态创建对象，调用成员
        //每个类对应一个Type对象，Type是用来描述类的，每个方法对应一个MethodInfo对象，每个属性对一个PropertyInfo这些就是类方法属性的元数据
       
        static void Main(string[] args)
        {
            Person p1= new Person ();
            Person p2 = new Person();
            Person p3 = new Person();
            Type type = p1.GetType();
            Type type1 = typeof(Person);
            Type type3=Type.GetType("反射入门.Person");
            Type type5 = typeof(Program);
            Console.WriteLine(type);
            Console.WriteLine(type1);
            Console.WriteLine(type3);
            Console.WriteLine(object.ReferenceEquals(type,type1));
            Console.WriteLine(object.ReferenceEquals(type3, type5));
            //用 Activator.CreateInstance(type);必须类要有无参的构造函数
            object obj =Activator.CreateInstance(type);//动态创建的t1指向的类的对象
            Person p = (Person)obj;
            Console.WriteLine(obj);

            Console.WriteLine(type3);
            Child1 c1 = new Child1();
            c1.Hello();
            Console.ReadKey();
        }
    }

    class Person
    {
        public override string ToString()
        {
            return "我是Person";
        }

    }
    class Parent
    {
        public void Hello()
        {
            //Type type = this.GetType();//this 不是代表"当前类",而是代表"当前 对象 ",this看做当前对象一个特殊变量
            //Console.WriteLine(type);
            this.Test();

        }
        public virtual void Test()
        {
            Console.WriteLine("Parent Test");

        }
    }
    class Child1 : Parent
    {
        public override void Test()
        {
           
            Console.WriteLine("Child1 Test");
        }

    }
    class Child2 : Parent
    {

    }
}
