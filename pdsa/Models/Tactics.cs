using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pdsa.Models
{
    public class Tactics
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Tactics()
        {
        }
        public Tactics(string name)
        {
            Name = name;
            Description = Description;
        }

    }
}
