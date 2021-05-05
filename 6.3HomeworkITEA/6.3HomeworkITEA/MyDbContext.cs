using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3HomeworkITEA
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("MyDbContext")
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Comp> Comps { get; set; }
    }
}
