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
    public class RuteModel : PageModel
    {
        private RuteCatalog _rCatalog;

        public RuteModel(RuteCatalog rCatalog)
        {
            _rCatalog = rCatalog;
        }

        public Dictionary<int, Rute> Rutes { get; private set; }
        public IActionResult OnGet()
        {
            Rutes = _rCatalog.AllRutes();
            return Page();
        }
    }
}
