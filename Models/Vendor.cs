using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryApp.Models
{
    public class Vendor
    {
        public int VendorId { set; get; }
        public string VendorPassword { set; get; }
        public string VendorAddress { set; get; }
        public string VendorPhoneNumber { set; get; }
        public string VendorEmail { set; get; }
    }
}
