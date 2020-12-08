using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeliveryApp.Catalogs;
using DeliveryApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DeliveryApp.Pages
{
    public class EmployeeModel : PageModel
    {
        private EmployeeCatalog _eCatalog;
      

        public EmployeeModel(EmployeeCatalog eCatalog)
        {
            _eCatalog = eCatalog;          
        }

        public Dictionary<int, Employee> Employees { get; private set; }
       
        public IActionResult OnGet()
        {
            Employees = _eCatalog.AllEmployees();
            return Page();
        }
    }
}
