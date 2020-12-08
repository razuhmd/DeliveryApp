using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryApp.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime ExpectedDeliveryDate { get; set; }
        public OrderAddresss Address { get; set; }
        public Vendor Vendor { get; set; }

        //public int OrderCalculateRute { set; get; }
    }
}
