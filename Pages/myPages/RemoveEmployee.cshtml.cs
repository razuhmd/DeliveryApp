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
    public class RemoveEmployeeModel : PageModel
    {
        [BindProperty]
        public Employee RemoveEmployee { get; set; }

        private EmployeeCatalog _eCatalog;
        public RemoveEmployeeModel(EmployeeCatalog eCatalog)
        {
            RemoveEmployee = new Employee();
            _eCatalog = eCatalog;

        }
        public IActionResult OnGet(int id)
        {
            RemoveEmployee = _eCatalog.GetEmployeeById(id);

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (RemoveEmployee != null)
            {
                _eCatalog.RemoveEmployee(RemoveEmployee);
            }

            return RedirectToPage("Employee");
        }
    }
}
