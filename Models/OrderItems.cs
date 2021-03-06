using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CofffeeLovers.Models
{
    public class OrderItems
    {
        [Required]
        public decimal Price { get; set; }

        [Required, Range(minimum: 1, maximum:6)]
        public int Quantity { get; set; }
    }
}
