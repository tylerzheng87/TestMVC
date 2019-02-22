using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFReady1
{
    public class FluentPerson
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return "Id=" + Id + ",Name=" + Name + ",CreateDateTime=" + CreateDateTime + ",Age=" + Age;
        }
    }
}
