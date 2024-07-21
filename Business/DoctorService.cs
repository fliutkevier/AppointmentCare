using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Domain;

namespace Business
{
    public class DoctorService : mainService
    {
        public DoctorService() : base() { }

        public List<Doctor> getAllDoctors()
        {
            List<Doctor> lstDoctors = new List<Doctor>();
            Doctor doctor = new Doctor();
            try
            {
                _context.SetQuery("SELECT Doc.Id, Per.Name, Per.Lastname, Per.DNI, Per.Address, Per.Phone, Per.Birthday, License, Spec.Description FROM DOCTORS Doc, Persons Per, Speciality Spec WHERE Doc.PersonId = Per.Id AND Doc.SpecialityId = Spec.Id");
                _context.ExecRead();

                while (_context.Reader.Read())
                {
                    doctor.Id = (int)_context.Reader["Id"];
                    doctor.Name = (string)_context.Reader["Name"];
                    doctor.Lastname = (string)_context.Reader["Lastname"];
                    doctor.Dni = (string)_context.Reader["DNI"];
                    doctor.Address = (string)_context.Reader["Address"];
                    doctor.Phone = (string)_context.Reader["Phone"];
                    DateTime dtHelp = (DateTime)_context.Reader["Birthday"];
                    doctor.BirthDay = DateOnly.FromDateTime(dtHelp);
                    doctor.License = (int)_context.Reader["License"];
                    doctor.SpecialityType = new Speciality();
                    doctor.SpecialityType.Description = (string)_context.Reader["Description"];

                    lstDoctors.Add(doctor);
                }

                return lstDoctors;
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
