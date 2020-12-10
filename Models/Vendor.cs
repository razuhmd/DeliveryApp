using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryApp.Models
{
    public class Vendor
    {
        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public string VendorAddress { get; set; }
        [Required]
        public string VendorPhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        public string VendorEmail { get; set; }
    }
}
