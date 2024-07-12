using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public int Dni { get; set; }
        public string Address { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public DateTime BirthDay { get; set; }
    }
}
