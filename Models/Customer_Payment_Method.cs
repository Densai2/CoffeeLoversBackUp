using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CofffeeLovers.Models
{
    public class Customer_Payment_Method
    {
        [Required]
        public int PaymentMethodCode { get; set; }
        [Required]
        public int CardNumber { get; set; }
        [Required]
        public DateTime DateOfPurcahse { get; set; }
        [Required]
        public Decimal Total { get; set; }
        [Required]
        public int BillNumber { get; set; }
    }
}
