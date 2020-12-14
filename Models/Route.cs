using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryApp.Models
{
    public class Route
    {
        [Required]
        public int RouteId { get; set; }
        [Required]
        public List<int> PostCodes { get; set; }
        public Employee Employee { get; set; }
    }
}
