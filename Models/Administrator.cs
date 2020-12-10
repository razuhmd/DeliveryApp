using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryApp.Models
{
    public class Administrator : Employee
    {
        public int AdministratorLoginId { set; get; }
        public string AdministratorPassword { set; get; }
        
    }
}
