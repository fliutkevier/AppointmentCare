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
        [DisplayName("Obra Social")]
        public virtual HealthInsurance HealthInsurance { get; set; } = null!;
        [DisplayName("Numero de Obra Social")]
        public string HealthInsuranceNumber { get; set; } = null!;
    }
}
