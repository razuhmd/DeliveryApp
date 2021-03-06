using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeliveryApp.Catalogs;
using DeliveryApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DeliveryApp.Pages.myPages
{
    public class CreateEmployeeModel : PageModel
    {
        
        private EmployeeCatalog _eCatalog;

        [BindProperty]
        public Employee Employee { get; set; }

        public CreateEmployeeModel(EmployeeCatalog eCatalog)
        {
            _eCatalog = eCatalog;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                _eCatalog.AddEmployees(Employee);
                return RedirectToPage("Employee");
            }
            else
            {
                return Page();
            }
           
        }
    }
}
