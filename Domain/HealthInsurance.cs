using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class HealthInsurance
    {
        public int Id { get; set; }
        public string Provider { get; set; } = null!;

        public override string ToString()
        {
            return Provider;
        }
    }
}
