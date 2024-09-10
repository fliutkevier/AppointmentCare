using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Domain;

namespace Business
{
    public class DoctorBusiness : mainBusiness
    {
        public DoctorBusiness() : base() { }

        public List<Doctor> GetAll()
        {
            List<Doctor> lstDoctors = new List<Doctor>();
            
            try
            {
                _context.SetQuery("SELECT p.Id AS IdPerson, p.IsActive, p.Name, p.Lastname, p.DNI, p.Address, p.Phone, p.Birthday, d.Id AS IdDoctor, d.License, d.SpecialityId, s.Description AS Speciality FROM Persons p INNER JOIN Doctors d ON d.PersonId = p.Id INNER JOIN Specialties s ON d.SpecialityId = s.Id");
                _context.ExecRead();

                while (_context.Reader.Read())
                {
                    Doctor doctor = new Doctor();
                    doctor.IdPerson = (int)_context.Reader["IdPerson"];
                    doctor.IdDoctor = (int)_context.Reader["IdDoctor"];
                    doctor.Name = (string)_context.Reader["Name"];
                    doctor.Lastname = (string)_context.Reader["Lastname"];
                    doctor.Dni = (string)_context.Reader["DNI"];
                    doctor.Address = (string)_context.Reader["Address"];
                    doctor.Phone = (string)_context.Reader["Phone"];
                    DateTime dtHelp = (DateTime)_context.Reader["Birthday"];
                    doctor.BirthDay = DateOnly.FromDateTime(dtHelp);
                    doctor.License = (string)_context.Reader["License"];
                    doctor.SpecialityType = new Speciality();
                    doctor.SpecialityType.Id = (int)_context.Reader["SpecialityId"];
                    doctor.SpecialityType.Description = (string)_context.Reader["Speciality"];
                    doctor.IsActive = (bool)_context.Reader["IsActive"];

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
                _context.SetQuery("INSERT INTO Persons VALUES (@Name, @Lastname, @Dni, @Address, @Phone, @Birthday, @IsActive)");
                _context.SetParameter("@Name", doc.Name);
                _context.SetParameter("@Lastname", doc.Lastname);
                _context.SetParameter("@Dni", doc.Dni);
                _context.SetParameter("@Address", doc.Address);
                _context.SetParameter("@Phone", doc.Phone);
                _context.SetParameter("@Birthday", doc.BirthDay);
                _context.SetParameter("@IsActive", true);

                if (_context.ExecAction())
                {
                    PersonBusiness perServ = new PersonBusiness();
                    doc.IdPerson = perServ.GetIdByDni(doc.Dni);
                    _context.Close();
                    if (doc.IdPerson <= 0)
                    {
                        return false;
                    }
                    _context.SetQuery("INSERT INTO Doctors VALUES (@PersonId, @License, @SpecialityId)");
                    _context.SetParameter("@PersonId", doc.IdPerson);
                    _context.SetParameter("@License", doc.License);
                    _context.SetParameter("@SpecialityId", doc.SpecialityType.Id);
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
                _context.ClearParameters();
                _context.SetQuery("UPDATE Persons SET Name = @Name, Lastname = @Lastname, DNI = @Dni, Address = @Address, Phone = @Phone, Birthday = @Birthday, IsActive = @IsActive WHERE Id = @Id");
                _context.SetParameter("@Name", doc.Name);
                _context.SetParameter("@Lastname", doc.Lastname);
                _context.SetParameter("@Dni", doc.Dni);
                _context.SetParameter("@Address", doc.Address);
                _context.SetParameter("@Phone", doc.Phone);
                _context.SetParameter("@Birthday", doc.BirthDay);
                _context.SetParameter("@Id", doc.IdPerson);
                _context.SetParameter("@IsActive", doc.IsActive);

                if (_context.ExecAction())
                {
                    _context.Close();
                    _context.ClearParameters();
                    _context.SetQuery("UPDATE Doctors SET License = @License, SpecialityId = @SpecialityId WHERE Id = @IdDoctor");
                    _context.SetParameter("@License", doc.License);
                    _context.SetParameter("@SpecialityId", doc.SpecialityType.Id);
                    _context.SetParameter("@IdDoctor", doc.IdDoctor);
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

        public bool SoftDelete(int id)
        {
            try
            {
                _context.ClearParameters();
                _context.SetQuery("UPDATE Persons SET IsActive = 0 WHERE Id = @Id");
                _context.SetParameter("@Id", id);

                if (_context.ExecAction())
                {
                    _context.Close();
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                throw;
            }
            finally { _context.Close(); }
        }

        public bool Remove(Doctor doc)
        {
            try
            {
                _context.ClearParameters();
                _context.SetQuery("DELETE FROM Doctors WHERE Id = @Id");
                _context.SetParameter("@Id", doc.IdDoctor);

                if (_context.ExecAction())
                {
                    _context.Close();
                    _context.ClearParameters();
                    _context.SetQuery("DELETE FROM Persons WHERE Id = @Id");
                    _context.SetParameter("@Id", doc.IdPerson);

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

        public List<string> getLicenses()
        {
            List<string> licensesList = new List<string>();

            try
            {
                _context.SetQuery("SELECT License FROM DOCTORS");
                _context.ExecRead();

                while (_context.Reader.Read())
                {
                    string license = (string)_context.Reader["License"];
                    
                    licensesList.Add(license);
                }

                return licensesList;
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

        public int getIdByLicense(string license)
        {
            int id = -1;

            try
            {
                _context.SetQuery("SELECT Id FROM Doctors WHERE License = @License");
                _context.SetParameter("@License", license);
                _context.ExecRead();

                if(_context.Reader.Read())
                {
                    id = (int)_context.Reader["Id"];
                }

                return id;
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

        public string GetLicenseById(int id)
        {
            string license = string.Empty;
            try
            {
                _context.SetQuery("SELECT License FROM Doctors WHERE Id = @IdDoctor");
                _context.SetParameter("@IdDoctor", id);
                _context.ExecRead();

                if (_context.Reader.Read())
                {
                    license = (string)_context.Reader["License"];
                }

                return license;
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

        public Doctor GetById(int id)
        {
            Doctor doctor = new Doctor();
            doctor.IdDoctor = 0;
            try
            {
                _context.ClearParameters();
                _context.SetQuery("SELECT p.Id AS PersonId, d.Id AS DoctorId, Name, Lastname, DNI, Address, Phone, Birthday, IsActive, License, SpecialityId FROM Persons p INNER JOIN Doctors d ON p.Id = d.PersonId WHERE d.Id = @Id");
                _context.SetParameter("@Id", id);
                _context.ExecRead();

                if (_context.Reader.Read())
                {
                    doctor.IdPerson = (int)_context.Reader["PersonId"];
                    doctor.IdDoctor = (int)_context.Reader["DoctorId"];
                    doctor.Name = (string)_context.Reader["Name"];
                    doctor.Lastname = (string)_context.Reader["Lastname"];
                    doctor.Dni = (string)_context.Reader["DNI"];
                    doctor.Address = (string)_context.Reader["Address"];
                    doctor.Phone = (string)_context.Reader["Phone"];
                    DateTime dtHelp = (DateTime)_context.Reader["Birthday"];
                    doctor.BirthDay = DateOnly.FromDateTime(dtHelp);
                    doctor.IsActive = (bool)_context.Reader["IsActive"];
                    doctor.License = (string)_context.Reader["License"];
                    doctor.SpecialityType = new Speciality();
                    doctor.SpecialityType.Id = (int)_context.Reader["SpecialityId"];
                }

                return doctor;
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
