using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Patient : Person
    {
        public int IdPatient { get; set; }
        [DisplayName("Obra Social")]
        public virtual HealthInsurance HealthInsurance { get; set; }
        [DisplayName("Numero de Obra Social")]
        public string HealthInsuranceNumber { get; set; }

        public Patient() : base()
        {
            IdPatient = 0;
            HealthInsurance = new HealthInsurance();
            HealthInsuranceNumber = string.Empty;
        }


    }
}
