using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Doctor : Person
    {
        private int _id;
        private int _license;
        private Speciality _speciality;

        public int License 
        { 
            get { return _license; } 
            set { _license = value; } 
        }

        public Speciality Speciality 
        { 
            get { return _speciality; } 
            set { _speciality = value; }
        }
    }
}
