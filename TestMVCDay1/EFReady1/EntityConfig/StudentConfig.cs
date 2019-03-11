using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFReady1.EntityConfig
{
    public  class StudentConfig:EntityTypeConfiguration<Student>
    {
         public StudentConfig()
        {
            ToTable("T_Students");
            this.HasMany(e => e.Teachers).WithMany(e=>e.Students)
                .Map(m => m.ToTable("T_StudentsTeachers").MapLeftKey("StudentId").MapRightKey("TeacherId"));

        }

    }
}
