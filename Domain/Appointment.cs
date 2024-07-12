using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Appointment
    {
        private int _id;
        private int _doctorId;
        private int _pacientId;
        private DateTime _shedule;
        public int Id { get; set; }
        public int DoctorId
        {
            get { return _doctorId; }
            set { _doctorId = value; }
        }
        public int PacientId
        {
            get { return _pacientId; }
            set { PacientId = value; }
        }
        public DateTime Schedule
        {
            get { return _shedule; }
            set { _shedule = value; }
        }
    }
}
