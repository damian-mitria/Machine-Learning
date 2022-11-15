using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Data.Entidades
{
    public class ViajeModel
    {
        public string Vendor_id { get; set; } = null!;
        public float Rate_code { get; set; }
        public float Passenger_count { get; set; }
        public float Trip_distance { get; set; }
        public string Payment_type { get; set; } = null!;
    }

}
