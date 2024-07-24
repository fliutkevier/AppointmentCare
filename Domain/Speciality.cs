using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Speciality
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public Speciality()
        {
            Id = 0;
            Description = string.Empty;
        }

        public override string ToString()
        {
            return Description;
        }
    }
}
