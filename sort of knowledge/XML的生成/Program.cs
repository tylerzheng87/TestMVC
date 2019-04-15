using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML的生成
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = { new Person(1, "rupeng", 8), new Person(2, "baidu", 4 )};
            XmlDocument doc = new XmlDocument();
            XmlElement ePersons = doc.CreateElement("Persons");
            doc.AppendChild(ePersons);//把Persons添加文档的子节点，由于文档还没有子节点，所以这个节点就是根节点
            //doc.AppendChild(doc.CreateElement("aaa"));根节点只能有一个
            foreach (Person p in persons)
            {
                XmlElement eP = doc.CreateElement("Person");//创建Person节点
                eP.SetAttribute("id", p.Id.ToString());//设置属性id=“1”
                XmlElement eName = doc.CreateElement("Name");//创建Name节点
                eName.InnerText = p.Name;//设置创建出来的节点的内部文本
                XmlElement eAge = doc.CreateElement("Age");
                eAge.InnerText = p.Age.ToString();
                eP.AppendChild(eName);//把Name节点添加到Person的节点下
                eP.AppendChild(eAge);
                ePersons.AppendChild(eP);// 把Person节点添加到Persons节点下 记得给他找爹
            }
            doc.Save("d:/temp/1.xml");
            Console.ReadKey();

        }
    }

    public class Person
    {
        public Person(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;


        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
