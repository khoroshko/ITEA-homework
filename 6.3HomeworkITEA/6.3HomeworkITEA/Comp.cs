using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3HomeworkITEA
{
    public class Comp
    {
        public int Id { get; set; }
        public string Name { get; set; } 

        public ICollection<User> Users { get; set; }
        public Comp()
        {
            Users = new List<User>();
        }
    }
}
