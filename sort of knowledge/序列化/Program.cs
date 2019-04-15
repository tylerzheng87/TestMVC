using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace 序列化
{
    class Program
    {
        static void Main(string[] args)
        {
            //如果之前的的类被修改了，被序列化的文件就不要用了，有可能会报错
            //序列化就是将内存中的对象永久的保存在流中
            /*
            Console.WriteLine("请输入姓名:");
            string name = Console.ReadLine();
            Console.WriteLine("请输入年龄：");
            string age = Console.ReadLine();
            Person p1 = new Person();
            p1.Name = name;
            p1.Age = Convert.ToInt32(age);
            BinaryFormatter binFor = new BinaryFormatter();
            using (FileStream fs = File.OpenWrite("d:/temp/1.data"))
            {
                binFor.Serialize(fs, p1);
            }
            */
            //一个类可序列化的条件是什么呢 这个类标记为serilizable
            //如果该类型所有成员的类型也必须标记为serilizable，该类型的父类也必须标记为serilizable，要序列化的类型必须标记serilizable
            BinaryFormatter binFor = new BinaryFormatter();
            using (FileStream fs = File.OpenRead("d:/temp/1.data"))
            {
               Person p1=(Person)binFor.Deserialize(fs);
                Console.WriteLine(p1.Age+p1.Name);
            }
                Console.ReadKey();
        }
        
    }
    [Serializable]
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
