using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class HealthInsurance
    {
        private int _id;
        private string _provider;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Provider
        {
            get { return _provider; }
            set { _provider = value; }
        }
    }
}
