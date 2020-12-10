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
    public class CreateRuteModel : PageModel
    {
        private RuteCatalog _rCatalog;

        [BindProperty]
        public Rute Rute { get; set; }

        public CreateRuteModel(RuteCatalog rCatalog)
        {
            _rCatalog = rCatalog;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                _rCatalog.AddRute(Rute);
                return RedirectToPage("Rute");               
            }
            else
            {
                return Page();
            }
           
        }
    }
}
