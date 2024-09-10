using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public static class SpecialityService
    {
        private static SpecialityBusiness bs;
        static SpecialityService()
        {
            bs = new SpecialityBusiness();
        }
        public static List<Speciality> GetAll()
        {
            return bs.getAll();
        }
    }
}
