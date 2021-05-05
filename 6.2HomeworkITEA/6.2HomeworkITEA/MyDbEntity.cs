using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2HomeworkITEA
{
    public class MyDbEntity : DbContext
    {
        public MyDbEntity()
            : base("name=MyDbEntity")
        {
        }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Player> Players { get; set; }
    }
}
