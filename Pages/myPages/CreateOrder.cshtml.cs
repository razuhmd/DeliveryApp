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
    public class CreateOrderModel : PageModel
    {
        private OrderCatalog _oCatalog;

        [BindProperty]
        public Order Order { get; set; }

        public CreateOrderModel(OrderCatalog oCatalog)
        {
            _oCatalog = oCatalog;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            { return Page(); }

            else
            { _oCatalog.AddOrder(Order); }
            
            return RedirectToPage("Order");
        }
    }
}
