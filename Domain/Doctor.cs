using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Doctor : Person
    {
        public int IdDoctor { get; set; }
        public string License { get; set; }
        public Speciality SpecialityType { get; set; }

        public Doctor() : base()
        {
            IdDoctor = 0;
            License = string.Empty;
            SpecialityType = new Speciality();
        }
    }
}
