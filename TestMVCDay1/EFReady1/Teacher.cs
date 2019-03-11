using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFReady1
{
    public class Teacher
    {
        //public Teacher()
        //{
        //    this.Students=new List<Person>();
        //}
        //public string Name { get; set; }
        //public List<Person> Students { get; set; }
        //多对多   
        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Student> Students { get; set; }=new List<Student>();

}
}
