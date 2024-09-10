using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using Domain;

namespace Service
{
    public static class PatientService
    {
        private static PatientBusiness business;
        static PatientService()
        {
            business = new PatientBusiness();
        }

        public static List<Patient> GetAllActives()
        {
            return business.GetAll().Where(patient => patient.IsActive).ToList();
        }

        public static bool Modify(Patient patient)
        {
            if(business.Modify(patient))
            {
                return true;
            }
            return false;
        }

        public static bool Add(Patient patient)
        {
            if(business.addPatient(patient))
            {
                return true;
            }
            return false;
        }
    }
}
