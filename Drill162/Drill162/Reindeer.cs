using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill162
{
    public class Reindeer
    {
        public string House { get; set; }
        public int age { get; set; }

        public Reindeer(string House) : this(House, 500)
        {
            return;
        }
        public Reindeer(string house, int age)
        {
            House = house;
            age = 250;
        }

       
    }
}    
               

