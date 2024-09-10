using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Business
{
    public class mainBusiness
    {
        protected readonly AppCareData _context;
        public mainBusiness()
        {
            _context = new AppCareData();
        }
    }
}
