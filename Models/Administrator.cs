using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryApp.Models
{
    public class Administrator
    {
        public string AdministratorLoginId { set; get; }
        public string AdministratorPassword { set; get; }
        public void ViewProducts() { }
        public void AddProduct() { }
        public void DeleteProduct() { }
        public void AddToRute() { }
        public void EditDeliveryStatus() { }
    }
}
