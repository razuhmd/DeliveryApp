using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryApp.Models
{
    public class Order
    {
        [Required]
        public int OrderId { get; set; }    
        public DateTime ExpectedDeliveryDate { get; set; }
        [Required]
        public OrderAddresss Address { get; set; }
        public Vendor Vendor { get; set; }

        //public int OrderCalculateRute { set; get; }
    }
}
