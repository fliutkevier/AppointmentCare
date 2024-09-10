using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public static class PersonService
    {
        private static PersonBusiness business;
        static PersonService()
        {
            business = new PersonBusiness();
        }

        public static bool SoftDelete(int id)
        {
            return business.SoftDelete(id);
        }
    }
}
