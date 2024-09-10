using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public static class HealthInsuranceService
    {
        private static HealthInsuranceBusiness bussiness;
        static HealthInsuranceService()
        {
            bussiness = new HealthInsuranceBusiness();
        }

        public static List<HealthInsurance> GetAll()
        {
            return bussiness.GetAll();
        }
    }
}
