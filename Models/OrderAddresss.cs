using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryApp.Models
{
    public class OrderAddresss
    {
        public int OrderAddressId { get; set; }
        public string CustomerName { get; set; }
        public string StreetHouse { get; set; }
        public int PostCode { get; set; }
        public string Town { get; set; }
        public string CustomerPhone { get; set; }

    }
}
