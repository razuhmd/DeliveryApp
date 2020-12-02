using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryApp.Models
{
    public class Product
    {
        public int ProductID { set; get; }
        public DateTime ExpectedDeliveryDate { set; get; }
        public string CustomerAddress { set; get; }
        public int VendorID { set; get; }

        public int CalculateRute { set; get; }
    }
}
