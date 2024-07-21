using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Person
    {
        public int Id { get; set; }
        [DisplayName("Nombre")]
        public string Name { get; set; } = null!;
        [DisplayName("Apellido")]
        public string Lastname { get; set; } = null!;
        [DisplayName("DNI")]
        public string Dni { get; set; } = null!;
        [DisplayName("Dirección")]
        public string Address { get; set; } = null!;
        [DisplayName("Telefono")]
        public string Phone { get; set; } = null!;
        [DisplayName("Fecha de Nacimiento")]
        public DateOnly BirthDay { get; set; }
    }
}
