using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CofffeeLovers.Models
{
    public class Products
    {
        enum Catergories { Toastie, Coffee, Tea, Desert, Crisps, }

        [Required, StringLength(maximumLength:20)]
        public string ProductName { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int Column { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public Catergories Catagory { get; set; } = Catergories.Tea;

        [Required]
        public int SupplierID { get; set; }
    }
}
