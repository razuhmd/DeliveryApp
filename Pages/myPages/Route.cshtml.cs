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
    public class RouteModel : PageModel
    {
        private RouteCatalog _rCatalog;

        public RouteModel(RouteCatalog rCatalog)
        {
            _rCatalog = rCatalog;
        }

        public Dictionary<int, Route> Routes { get; private set; }
        public IActionResult OnGet()
        {
            Routes = _rCatalog.AllRoutes();
            return Page();
        }
    }
}
