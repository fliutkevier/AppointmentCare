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
		private readonly AppCareData _context;
		public PatientService() 
		{
			_context = new AppCareData();
		}
        public List<Patient> getAllPatients()
        {
			List<Patient> patients = new List<Patient>();
			Patient patient = new Patient();
			try
			{
				_context.SetQuery("SELECT Per.Id, Name, Lastname, DNI, H.Provider, Pat.HealthInsuranceNumber, Address, Phone, Birthday FROM Persons Per, Patients Pat, HealthInsurances H WHERE Per.Id = Pat.PersonId AND Pat.HealthInsuranceId = H.Id");
				_context.ExecRead();

				while (_context.Reader.Read())
				{
					patient.Id = (int)_context.Reader["Id"];
					patient.Name = (string)_context.Reader["Name"];
					patient.Lastname = (string)_context.Reader["Lastname"];
					patient.Dni = (int)_context.Reader["DNI"];
					patient.HealthInsurance = new HealthInsurance();
					patient.HealthInsurance.Provider = (string)_context.Reader["Provider"];
					patient.HealthInsuranceNumber = (string)_context.Reader["HealthInsuranceNumber"];
					patient.Address = (string)_context.Reader["Address"];
					patient.Phone = (string)_context.Reader["Phone"];
					patient.BirthDay = (DateTime)_context.Reader["Birthday"];

					patients.Add(patient);
                }

				return patients;
			}
			catch (Exception ex)
			{

				throw;
			}
        }
    }
}
