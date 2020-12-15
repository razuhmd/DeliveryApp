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
    public class EditEmployeeModel : PageModel
    {
        [BindProperty]
        public Employee EditEmployee { get; set; }

        private EmployeeCatalog _eCatalog;
        public EditEmployeeModel(EmployeeCatalog eCatalog)
        {
            EditEmployee = new Employee();
            _eCatalog = eCatalog;

        }
        public IActionResult OnGet(int id)
        {
            EditEmployee = _eCatalog.GetEmployeeById(id);

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (EditEmployee != null)
            {
                _eCatalog.UpdateEmployee(EditEmployee);
            }

            return RedirectToPage("Employee");
        }

    }
}
