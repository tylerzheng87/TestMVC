using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFReady1
{
    public  class TestDbContext:DbContext
    {
        public TestDbContext() : base("name=sqlConn")
        {



        }
        public DbSet<PersonEF> PersonEF { get; set; }
    }
}
