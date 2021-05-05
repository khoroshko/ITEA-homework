using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1HomeworkITEA
{
    public class SoccerContext : DbContext
    {
        public SoccerContext() : base("SoccerContext")
        { }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
