using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFReady1
{
    [Table("T_Persons")]
    public class PersonEF
    {
        public long Id { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string Name { get; set; }
    }
}
