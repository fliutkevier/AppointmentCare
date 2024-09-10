using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Domain;

namespace Business
{
    public class HealthInsuranceBusiness : mainBusiness
    {
        public HealthInsuranceBusiness() : base() { }

        public List<HealthInsurance> GetAll()
        {
            List<HealthInsurance> insurances = new List<HealthInsurance>();
            
            try
            {
                _context.SetQuery("SELECT Id, Provider FROM HealthInsurances");
                _context.ExecRead();

                while (_context.Reader.Read())
                {
                    HealthInsurance insur = new HealthInsurance();
                    insur.Id = (int)_context.Reader["Id"];
                    insur.Provider = (string)_context.Reader["Provider"];
                    
                    insurances.Add(insur);
                }

                return insurances;
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
