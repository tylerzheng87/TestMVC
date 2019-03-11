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
            this.Property(e => e.Name).HasMaxLength(30);//HasMaxLength加上他就不会提交给服务器
        }

    }
}
