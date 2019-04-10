using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace 反射Attribute
{
    class Program
    {
        [MyTest]
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Tman";
            p1.Age = 6;
            //获取type上标注的ObsoleteAttribute
            Type type = p1.GetType();
            object[] obsoleteAttribute= type.GetCustomAttributes(typeof(ObsoleteAttribute), false);
            if (obsoleteAttribute.Length>0)
            {
               
                    Console.WriteLine("这个类已经过时");
                
            }
            else
            {
                Console.WriteLine("这个类没有过时");
            }

            foreach (PropertyInfo prop in type.GetProperties())
            {
                string name = prop.Name;
              //  object value = prop.GetValue(p1);
                /*
                string displayName;
                object[] displayAttrs=prop.GetCustomAttributes(typeof(DisplayNameAttribute),false);
                if (displayAttrs.Length<=0)
                {
                    displayName = null;
                        
                }
                else
                {
                    DisplayNameAttribute displayNameAttribute = (DisplayNameAttribute)displayAttrs[0];
                    displayName = displayNameAttribute.DisplayName;
                }
                Console.WriteLine(name+"("+displayAttrs+")"+"="+value);
            }
            */
              
                DisplayNameAttribute displayNameAttr = (DisplayNameAttribute)prop.GetCustomAttribute(typeof(DisplayNameAttribute));
                string displayName;
                if (displayNameAttr == null)
                {
                    displayNameAttr = null;
                }
                else
                {
                    displayName = displayNameAttr.DisplayName;
                }
                JapaneseDisplayNameAttribute jpAttr = (JapaneseDisplayNameAttribute)
                    prop.GetCustomAttribute(typeof(JapaneseDisplayNameAttribute));
                string jpName;
                if (jpAttr==null)
                {
                    jpName = "没有日文名字";
                }
                else
                {
                    jpName = jpAttr.DisplayName;
                }
                object value = prop.GetValue(p1);
                Console.WriteLine(jpName +  "=" + value);
                Console.ReadKey();
            }
        }
    }

    class Person
    {
        public Person()
        {

        }
        public Person(string name)
        {


        }
        [DisplayName("姓名")]
        [JapaneseDisplayNameAttribute("yamade")]
        public string Name { get; set; }
        public int Age { get; set; }
        [Obsolete]//意味着这个分方法不能用了或者成员已经过时
        public void SayHi()
        {
            Console.WriteLine("大家好,我是" + this.Name + "，我的年龄" + this.Age);
        }
    }
}
