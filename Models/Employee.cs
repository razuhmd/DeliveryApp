using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryApp.Models
{
    public class Employee
    {
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        [EmailAddress]
        public string EmployeeEmail { get; set;}
        public string EmployeeAddress { get; set; }
        public string EmployeePhoneNumber { get; set; }
        public string EmployeeType { get; set; }

    }

}
