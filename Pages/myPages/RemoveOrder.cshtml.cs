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
    public class RemoveOrderModel : PageModel
    {
        [BindProperty]
        public Order RemoveOrder { get; set; }

        private OrderCatalog _oCatalog;
        public RemoveOrderModel(OrderCatalog oCatalog)
        {
            RemoveOrder = new Order();
            _oCatalog = oCatalog;

        }
        public IActionResult OnGet(int id)
        {
            RemoveOrder = _oCatalog.GetOrderById(id);

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (RemoveOrder != null)
            {
                _oCatalog.RemoveOrder(RemoveOrder);
            }

            return RedirectToPage("Order");
        }
    }
}
