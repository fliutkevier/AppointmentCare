using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Domain;
using Microsoft.Identity.Client;

namespace Business
{
    public class SpecialityBusiness : mainBusiness
    {
        public SpecialityBusiness() : base() { }

        public List<Speciality> getAll()
        {
            List<Speciality> specialities = new List<Speciality>();

            try
            {
                _context.SetQuery("SELECT Id, Description FROM Specialties");
                _context.ExecRead();

                while (_context.Reader.Read())
                {
                    Speciality speci = new Speciality();
                    speci.Id = (int)_context.Reader["Id"];
                    speci.Description = (string)_context.Reader["Description"];

                    specialities.Add(speci);
                }

                return specialities;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _context.Close();
            }
        }
    }
}
