using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryApp.Models
{
    public class OrderAddresss
    {
        [Required]
        public int OrderAddressId { get; set; }
        public string CustomerName { get; set; }
        [Required]
        public string StreetHouse { get; set; }
        [Required]
        public int PostCode { get; set; }
        public string Town { get; set; }
        public string CustomerPhone { get; set; }

    }
}
