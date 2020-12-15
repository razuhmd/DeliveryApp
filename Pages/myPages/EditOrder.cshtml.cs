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
    public class EditOrderModel : PageModel
    {
        [BindProperty]
        public Order EditOrder { get; set; }

        private OrderCatalog _oCatalog;
        public EditOrderModel(OrderCatalog oCatalog)
        {
            EditOrder = new Order();
            _oCatalog = oCatalog;

        }
        public IActionResult OnGet(int id)
        {
            EditOrder = _oCatalog.GetOrderById(id);

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (EditOrder != null)
            {
                _oCatalog.UpdateOrder(EditOrder);
            }

            return RedirectToPage("Order");
        }

    }
}
