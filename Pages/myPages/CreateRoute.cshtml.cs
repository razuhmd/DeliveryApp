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
    public class CreateRouteModel : PageModel
    {
        private RouteCatalog _rCatalog;
       
        [BindProperty]
        public Route Route { get; set; }

        //[BindProperty]
        //private Employee Employee { get; set; }

        //[BindProperty]
        //private EmployeeCatalog eCatalog { get; }

        public CreateRouteModel(RouteCatalog rCatalog)
        {
            _rCatalog = rCatalog;
          
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            //var employeeId = Int32.Parse(Request.Form["employeeId"]);
            //Employee = eCatalog.GetEmployeeById(employeeId);
            //Rute.Employee = Employee;
            if (ModelState.IsValid)
            {
                //Employee = eCatalog.GetEmployeeById(Rute.Employee.EmployeeId);
                //Rute.Employee = Employee;

                _rCatalog.AddRoute(Route);
                return RedirectToPage("Route");               
            }
            else
            {
                return Page();
            }
           
        }
    }
}
