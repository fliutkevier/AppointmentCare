﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Speciality
    {
        private int _id;
        private string _description;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
    }
}
