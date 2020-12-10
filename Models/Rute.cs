using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryApp.Models
{
    public class Rute
    {
        [Required]
        public int RuteId { get; set; }
        public Employee Employee { get; set; }
    }
}
