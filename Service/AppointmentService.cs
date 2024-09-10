using Business;
using Domain;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public static class AppointmentService
    {
        private static AppointmentBusiness bs;

        static AppointmentService()
        {
            bs = new AppointmentBusiness();
        }

        public static bool Cancel(int id)
        {
            if (bs.Cancel(id))
            {
                return true;
            }
            return false;
        }

        public static bool Add(Appointment appointment)
        {
            if(bs.Add(appointment))
            {
                return true;
            }
            return false;
        }

        public static bool Modify(Appointment appointment)
        {
            if (bs.Modify(appointment))
            {
                return true;
            }
            return false;
        }
    }
}
