using EFReady1.EntityConfig;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFReady1
{
    public  class TestDbContext:DbContext
    {
        public TestDbContext() : base("name=PostgreSqlDb")
        {



        }
        public DbSet<PersonEF> PersonEF { get; set; }
        public DbSet<FluentPerson>FluentPerson { get; set; }

        //以下for FluentAPI

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //大项目这么用
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
            //从某个程序集中加在所有继承EntityTYpeConfiguration
            //modelBuilder.Configurations.AddFromAssembly(Assembly.Load("ModelConfig"));


            // 小项目可以这么写，主调上面的代码modelBuilder.Entity<Person>().ToTable("Persons");
            //还可以这么写
           // modelBuilder.Configurations.Add(new PersonConfig());
        }
    }
}
