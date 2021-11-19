using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CofffeeLovers.Models
{
    public class Order
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public int TableNo { get; set; }
        [Required]
        public DateTime TimeRecieved { get; set; }
        [Required]
        public DateTime Timestamp { get; set; }
    }
}
