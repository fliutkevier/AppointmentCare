﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Business
{
    public class mainService
    {
        protected readonly AppCareData _context;
        public mainService()
        {
            _context = new AppCareData();
        }
    }
}
