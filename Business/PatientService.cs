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

		public List<Patient> getAllPatients()
        {
			List<Patient> patients = new List<Patient>();
			try
			{
				_context.SetQuery("SELECT Per.Id, Pat.Id AS IdPatient, Name, Lastname, DNI, H.Provider, Pat.HealthInsuranceNumber, Address, Phone, Birthday FROM Persons Per, Patients Pat, HealthInsurances H WHERE Per.Id = Pat.PersonId AND Pat.HealthInsuranceId = H.Id");
				_context.ExecRead();

				while (_context.Reader.Read())
				{
                    Patient patient = new Patient();
                    patient.IdPerson = (int)_context.Reader["Id"];
                    patient.IdPatient = (int)_context.Reader["IdPatient"];
					patient.Name = (string)_context.Reader["Name"];
					patient.Lastname = (string)_context.Reader["Lastname"];
					patient.Dni = (string)_context.Reader["DNI"];
					patient.HealthInsurance = new HealthInsurance();
					patient.HealthInsurance.Provider = (string)_context.Reader["Provider"];
					patient.HealthInsuranceNumber = (string)_context.Reader["HealthInsuranceNumber"];
					patient.Address = (string)_context.Reader["Address"];
					patient.Phone = (string)_context.Reader["Phone"];
					DateTime dtHelp = (DateTime)_context.Reader["Birthday"];
                    patient.BirthDay = DateOnly.FromDateTime(dtHelp);

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
                _context.SetQuery("INSERT INTO Persons VALUES (@Name, @Lastname, @Dni, @Address, @Phone, @Birthday)");
                _context.SetParammeter("@Name", objPat.Name);
                _context.SetParammeter("@Lastname", objPat.Lastname);
                _context.SetParammeter("@Dni", objPat.Dni);
                _context.SetParammeter("@Address", objPat.Address);
                _context.SetParammeter("@Phone", objPat.Phone);
                _context.SetParammeter("@Birthday", objPat.BirthDay);

				if(_context.ExecAction())
				{
					PersonService perServ = new PersonService();
					objPat.IdPerson = perServ.GetIdByDni(objPat.Dni);
					_context.Close();
					if(objPat.IdPerson == -1)
					{
						return false;
					}
                    _context.SetQuery("INSERT INTO Patients VALUES (@PersonId, @HealthInsurance, @HealthInsuranceNumber)");
                    _context.SetParammeter("@PersonId", objPat.IdPerson);
                    _context.SetParammeter("@HealthInsurance", objPat.HealthInsurance.Id);
                    _context.SetParammeter("@HealthInsuranceNumber", objPat.HealthInsuranceNumber);
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
		
		public bool ModifyPatient(Patient objPat)
		{
			try
			{
                _context.SetQuery("UPDATE Persons SET Name = @Name, Lastname = @Lastname, DNI = @Dni, Address = @Address, Phone = @Phone, Birthday = @Birthday WHERE Id = @Id");
                _context.SetParammeter("@Name", objPat.Name);
                _context.SetParammeter("@Lastname", objPat.Lastname);
                _context.SetParammeter("@Dni", objPat.Dni);
                _context.SetParammeter("@Address", objPat.Address);
                _context.SetParammeter("@Phone", objPat.Phone);
                _context.SetParammeter("@Birthday", objPat.BirthDay);
                _context.SetParammeter("@Id", objPat.IdPerson);

                if (_context.ExecAction())
                {
                    _context.Close();
                    _context.SetQuery("UPDATE Patients SET HealthInsuranceId = @HealthInsurance, HealthInsuranceNumber = @HealthInsuranceNumber WHERE Id = @IdPatient");
                    _context.SetParammeter("@HealthInsurance", objPat.HealthInsurance.Id);
                    _context.SetParammeter("@HealthInsuranceNumber", objPat.HealthInsuranceNumber);
                    _context.SetParammeter("@IdPatient", objPat.IdPatient);
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

		public bool Delete(Patient objPat)
		{
            try
            {
                _context.SetQuery("DELETE FROM Patients WHERE Id = @IdPatient");
                _context.SetParammeter("@IdPatient", objPat.IdPatient);

                if (_context.ExecAction())
                {
                    _context.Close();
                    _context.SetQuery("DELETE FROM Persons WHERE Id = @IdPerson");
                    _context.SetParammeter("@IdPerson", objPat.IdPerson);
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
