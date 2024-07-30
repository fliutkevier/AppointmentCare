using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Appointment
    {
        public int Id { get; set; }
        [DisplayName("Profesional")]
        public int DoctorId { get; set; }
        [DisplayName("Paciente")]
        public int PatientId { get; set; }
        [DisplayName("Fecha y Hora")]
        public DateTime Schedule { get; set; }
    }
}
