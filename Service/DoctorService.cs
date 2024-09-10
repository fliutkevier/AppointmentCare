using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using Domain;

namespace Service
{
    public static class DoctorService
    {
        private static DoctorBusiness bs;
        static DoctorService()
        {
            bs = new DoctorBusiness();
        }

        public static List<Doctor> GetAllActives()
        {
            return bs.GetAll().Where(doctor => doctor.IsActive).ToList();
        }

        public static bool SoftDelete(int id)
        {
            return bs.SoftDelete(id);
        }

        public static bool Add(Doctor doctor)
        {
            if(bs.Add(doctor))
            {
                return true;
            }
            return false;
        }

        public static bool Modify(Doctor doctor)
        {
            if (bs.Modify(doctor))
            {
                return true;
            }
            return false;
        }
    }
}
