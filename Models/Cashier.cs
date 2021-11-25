using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CofffeeLovers.Models
{
    public class Cashier
    {
        [Required, StringLength(maximumLength: 10)]
        public int OrderItemsOrderID { get; set; }

        [Required, StringLength(maximumLength: 10)]
        public int OrderItemsProductsID { get; set; }

        [Required, StringLength(maximumLength: 3)]
        public int StaffID { get; set; }

        [Required, StringLength(maximumLength: 15)]
        public string FirstName { get; set; }

        [Required, StringLength(maximumLength: 15)]
        public string LastName { get; set; }

        [Required, StringLength(maximumLength: 30)]
        public string Email { get; set; }
    }
}
