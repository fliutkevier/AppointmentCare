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
        public int IdPerson { get; set; }
        [DisplayName("Nombre")]
        public string Name { get; set; }
        [DisplayName("Apellido")]
        public string Lastname { get; set; }
        [DisplayName("DNI")]
        public string Dni { get; set; }
        [DisplayName("Dirección")]
        public string Address { get; set; }
        [DisplayName("Telefono")]
        public string Phone { get; set; }
        [DisplayName("Fecha de Nacimiento")]
        public DateOnly BirthDay { get; set; }

        public Person()
        {
            IdPerson = 0;
            Name = string.Empty;
            Lastname = string.Empty;
            Dni = string.Empty;
            Address = string.Empty;
            Phone = string.Empty;
            BirthDay = new DateOnly(1, 1, 1);
        }
    }
}
