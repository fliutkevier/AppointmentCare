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

        public List<Doctor> GetAll()
        {
            List<Doctor> lstDoctors = new List<Doctor>();
            Doctor doctor = new Doctor();
            try
            {
                _context.SetQuery("SELECT Per.Id, Doc.Id AS IdDoctor, Per.Name, Per.Lastname, Per.DNI, Per.Address, Per.Phone, Per.Birthday, License, Spec.Description FROM DOCTORS Doc, Persons Per, Speciality Spec WHERE Doc.PersonId = Per.Id AND Doc.SpecialityId = Spec.Id");
                _context.ExecRead();

                while (_context.Reader.Read())
                {
                    doctor.IdPerson = (int)_context.Reader["Id"];
                    doctor.IdDoctor = (int)_context.Reader["IdDoctor"];
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

        public bool Add(Doctor doc)
        {
            try
            {
                _context.SetQuery("INSERT INTO Persons VALUES (@Name, @Lastname, @Dni, @Address, @Phone, @Birthday)");
                _context.SetParammeter("@Name", doc.Name);
                _context.SetParammeter("@Lastname", doc.Lastname);
                _context.SetParammeter("@Dni", doc.Dni);
                _context.SetParammeter("@Address", doc.Address);
                _context.SetParammeter("@Phone", doc.Phone);
                _context.SetParammeter("@Birthday", doc.BirthDay);

                if (_context.ExecAction())
                {
                    PersonService perServ = new PersonService();
                    doc.IdPerson = perServ.GetIdByDni(doc.Dni);
                    _context.Close();
                    if (doc.IdPerson <= 0)
                    {
                        return false;
                    }
                    _context.SetQuery("INSERT INTO Doctors VALUES (@PersonId, @License, @SpecialityId)");
                    _context.SetParammeter("@PersonId", doc.IdPerson);
                    _context.SetParammeter("@License", doc.License);
                    _context.SetParammeter("@SpecialityId", doc.SpecialityType.Id);
                    if (_context.ExecAction())
                    {
                        _context.Close();
                        return true;
                    }
                }

                return false;
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

        public bool Modify(Doctor doc)
        {
            try
            {
                _context.SetQuery("UPDATE Persons SET Name = @Name, Lastname = @Lastname, DNI = @Dni, Address = @Address, Phone = @Phone, Birthday = @Birthday WHERE Id = @Id");
                _context.SetParammeter("@Name", doc.Name);
                _context.SetParammeter("@Lastname", doc.Lastname);
                _context.SetParammeter("@Dni", doc.Dni);
                _context.SetParammeter("@Address", doc.Address);
                _context.SetParammeter("@Phone", doc.Phone);
                _context.SetParammeter("@Birthday", doc.BirthDay);
                _context.SetParammeter("@Id", doc.IdPerson);

                if (_context.ExecAction())
                {
                    _context.Close();
                    _context.SetQuery("UPDATE Doctors SET License = @License, SpecialityId = @SpecialityId WHERE Id = @IdDoctor");
                    _context.SetParammeter("@License", doc.License);
                    _context.SetParammeter("@SpecialityId", doc.SpecialityType.Id);
                    _context.SetParammeter("@IdPatient", doc.IdDoctor);
                    if (_context.ExecAction())
                    {
                        _context.Close();
                        return true;
                    }
                }

                return false;
            }
            catch (Exception)
            {

                throw;
            }
            finally { _context.Close(); }
        }

        public bool Delete(Doctor doc)
        {
            try
            {
                _context.SetQuery("DELETE FROM Doctors WHERE Id = @IdDoctor");
                _context.SetParammeter("@IdPatient", doc.IdDoctor);

                if (_context.ExecAction())
                {
                    _context.Close();
                    _context.SetQuery("DELETE FROM Persons WHERE Id = @IdPerson");
                    _context.SetParammeter("@IdPerson", doc.IdPerson);
                    if (_context.ExecAction())
                    {
                        _context.Close();
                        return true;
                    }
                }

                return false;
            }
            catch (Exception)
            {
                throw;
            }
            finally { _context.Close(); }
        }
    }
}
