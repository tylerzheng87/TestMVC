using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFReady1.EntityConfig
{
    public  class PersonConfig:EntityTypeConfiguration<FluentPerson>
    {
        public PersonConfig()
        {
            this.ToTable("T_Persons");
        }

    }
}
