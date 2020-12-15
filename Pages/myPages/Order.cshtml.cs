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
    public class OrderModel : PageModel
    {
        private OrderCatalog _oCatalog;

        public OrderModel(OrderCatalog oCatalog)
        {
            _oCatalog = oCatalog;
        }

        public Dictionary<int, Order> Orders { get; private set; }

        [BindProperty(SupportsGet = true)]
        public string SearchFor { get; set; }

        public IActionResult OnGet()
        {
            Orders = _oCatalog.AllOrders();

            if (!String.IsNullOrEmpty(SearchFor))
            {
                Orders = _oCatalog.Search(SearchFor);
            }
            return Page();
        }
    }
}
