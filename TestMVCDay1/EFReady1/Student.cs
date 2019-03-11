using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFReady1
{
    public class Student
    {
        public long Id { get; set; }
        public string Name { get; set; }
        //延迟加载关联对象属性，普通东西没这东西
        //不要手贱把两个延迟加载的配置设置为false.
        //设置virtual之后s指向的对象不是Student类对象，而是Student类的子类
        //去掉virtual之后s指向的就是Student类的对象
        //延迟加载提高了服务器的压力，本应该一次sql就可以吧所有数据都取出来，用的时候才加载避免了一次性加载了所有的数据提高了加载速度
        public virtual ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
        //又想方便又想提高性能不想延迟加载 不然student .class 属性不出来
        //使用include方法:var s=ctx.Students.Include("Teachers").First();

    }
}
