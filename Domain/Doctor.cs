using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Doctor : Person
    {
        public int Id { get; set; }
        public int License { get; set; }
        public Speciality SpecialityType { get; set; }
    }
}
