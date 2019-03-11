using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFEntities
{
    public class MyContext: DbContext
    {
        public MyContext() : base("name=Connstring")
        {


        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(
                Assembly.GetExecutingAssembly()
                );
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<MinZu> Minzus { get; set; }
        public DbSet<Class> Classes { get; set; }
    }
}
