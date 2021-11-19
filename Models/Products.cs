using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CofffeeLovers.Models
{
    public class Products
    {
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Column { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Category { get; set; }
        [Required]
        public int SupplierID { get; set; }
    }
}
