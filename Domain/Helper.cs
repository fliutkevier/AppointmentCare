using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public static class Helper
    {
        public static bool IsOnlyNumber(string txt)
        {
            int isNumber;
            if (!int.TryParse(txt, out isNumber))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
