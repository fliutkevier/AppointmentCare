using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Domain;

namespace Business
{
    public class PatientService : mainService
    {
        public PatientService() : base() { }
        public List<Person> getAllPatients()
        {
            var lst = _context.Persons;

            return lst.ToList();
        }
    }
}
