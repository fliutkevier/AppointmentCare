using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Domain;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Business
{
    public class PatientBusiness : mainBusiness
    {
        List<Patient> _list;
		public PatientBusiness() : base() { }

		public List<Patient> GetAll()
        {
			List<Patient> patients = new List<Patient>();
			try
			{
				_context.SetQuery("SELECT per.Id AS IdPerson, per.Name, per.Lastname, per.DNI, per.Address, per.Phone, per.Birthday, per.IsActive, pat.Id AS IdPatient, pat.HealthInsuranceNumber, h.Id AS IdProvider, h.Provider FROM Persons per INNER JOIN Patients pat ON pat.PersonId = per.Id INNER JOIN HealthInsurances h ON h.Id = pat.HealthInsuranceId");
				_context.ExecRead();

				while (_context.Reader.Read())
				{
                    Patient patient = new Patient();
                    patient.IdPerson = (int)_context.Reader["IdPerson"];
                    patient.IdPatient = (int)_context.Reader["IdPatient"];
					patient.Name = (string)_context.Reader["Name"];
					patient.Lastname = (string)_context.Reader["Lastname"];
					patient.Dni = (string)_context.Reader["DNI"];
					patient.HealthInsurance = new HealthInsurance();
					patient.HealthInsurance.Id = (int)_context.Reader["IdProvider"];
                    patient.HealthInsurance.Provider = (string)_context.Reader["Provider"];
					patient.HealthInsuranceNumber = (string)_context.Reader["HealthInsuranceNumber"];
					patient.Address = (string)_context.Reader["Address"];
					patient.Phone = (string)_context.Reader["Phone"];
					DateTime dtHelp = (DateTime)_context.Reader["Birthday"];
                    patient.BirthDay = DateOnly.FromDateTime(dtHelp);
                    patient.IsActive = (bool)_context.Reader["IsActive"];

					patients.Add(patient);
                }

				return patients;
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

		public bool addPatient(Patient objPat)
		{
			try
			{
                _context.ClearParameters();
                _context.SetQuery("INSERT INTO Persons VALUES (@Name, @Lastname, @Dni, @Address, @Phone, @Birthday, @IsActive)");
                _context.SetParameter("@Name", objPat.Name);
                _context.SetParameter("@Lastname", objPat.Lastname);
                _context.SetParameter("@Dni", objPat.Dni);
                _context.SetParameter("@Address", objPat.Address);
                _context.SetParameter("@Phone", objPat.Phone);
                _context.SetParameter("@Birthday", objPat.BirthDay);
                _context.SetParameter("@IsActive", objPat.IsActive);

				if(_context.ExecAction())
				{
					PersonBusiness perServ = new PersonBusiness();
					objPat.IdPerson = perServ.GetIdByDni(objPat.Dni);
					_context.Close();
					if(objPat.IdPerson == -1)
					{
						return false;
					}
                    _context.ClearParameters();
                    _context.SetQuery("INSERT INTO Patients VALUES (@PersonId, @HealthInsurance, @HealthInsuranceNumber)");
                    _context.SetParameter("@PersonId", objPat.IdPerson);
                    _context.SetParameter("@HealthInsurance", objPat.HealthInsurance.Id);
                    _context.SetParameter("@HealthInsuranceNumber", objPat.HealthInsuranceNumber);
                    if(_context.ExecAction())
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
		
		public bool Modify(Patient objPat)
		{
			try
			{
                _context.ClearParameters();
                _context.SetQuery("UPDATE Persons SET Name = @Name, Lastname = @Lastname, DNI = @Dni, Address = @Address, Phone = @Phone, Birthday = @Birthday, IsActive = @IsActive WHERE Id = @Id");
                _context.SetParameter("@Name", objPat.Name);
                _context.SetParameter("@Lastname", objPat.Lastname);
                _context.SetParameter("@Dni", objPat.Dni);
                _context.SetParameter("@Address", objPat.Address);
                _context.SetParameter("@Phone", objPat.Phone);
                _context.SetParameter("@Birthday", objPat.BirthDay);
                _context.SetParameter("@Id", objPat.IdPerson);
                _context.SetParameter("@IsActive", objPat.IsActive);

                if (_context.ExecAction())
                {
                    _context.Close();
                    _context.ClearParameters();
                    _context.SetQuery("UPDATE Patients SET HealthInsuranceId = @HealthInsurance, HealthInsuranceNumber = @HealthInsuranceNumber WHERE Id = @IdPatient");
                    _context.SetParameter("@HealthInsurance", objPat.HealthInsurance.Id);
                    _context.SetParameter("@HealthInsuranceNumber", objPat.HealthInsuranceNumber);
                    _context.SetParameter("@IdPatient", objPat.IdPatient);
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

        public bool SoftDelete(Patient objPat)
        {
            try
            {
                _context.ClearParameters();
                _context.SetQuery("UPDATE Persons IsActive = 0 WHERE Id = @Id");
                _context.SetParameter("@Id", objPat.IdPerson);

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

		public bool Remove(Patient objPat)
		{
            try
            {
                _context.SetQuery("DELETE FROM Patients WHERE Id = @IdPatient");
                _context.SetParameter("@IdPatient", objPat.IdPatient);

                if (_context.ExecAction())
                {
                    _context.Close();
                    _context.SetQuery("DELETE FROM Persons WHERE Id = @IdPerson");
                    _context.SetParameter("@IdPerson", objPat.IdPerson);
                    if (_context.ExecAction())
                    {
                        AppointmentBusiness appointmentService = new AppointmentBusiness();
                        appointmentService.Cancel(objPat.IdPatient);
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

        public Patient GetById(int id)
        {
            _list = GetAll();
            return _list.First(patient => patient.IdPatient == id);
        }
    }
}
