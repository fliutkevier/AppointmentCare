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
        public int DoctorId { get; set; }
        [DisplayName("Nombre de Profesional")]
        public string DoctorName { get; set; }
        [DisplayName("Apellido")]
        public string DoctorLastname { get; set; }
        [DisplayName("Legajo")]
        public string DoctorLicense { get; set; }
        [DisplayName("Nombre de Paciente")]
        public string PatientName { get; set; }
        [DisplayName("Apellido")]
        public string PatientLastname { get; set; }
        [DisplayName("DNI")]
        public string PatientDni { get; set; }
        public int PatientId { get; set; }
        [DisplayName("Fecha y Hora")]
        public DateTime Schedule { get; set; }

        public Appointment()
        {
            Id = 0;
            DoctorId = 0;
            DoctorName = string.Empty;
            DoctorLastname = string.Empty;
            DoctorLicense = string.Empty;
            PatientId = 0;
            PatientName = "NO ASIGNADO";
            PatientLastname = "NO ASIGNADO";
            PatientDni = "NO ASIGNADO";
            Schedule = DateTime.MinValue;
        }
    }
}
