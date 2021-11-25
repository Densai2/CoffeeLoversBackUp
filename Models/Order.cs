using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CofffeeLovers.Models
{
    public class Order
    {
        [Required, Range(minimum: 1, maximum: 100)]
        public int ID { get; set; }

        [Required, Range(minimum: 1, maximum: 20)]
        public int TableNo { get; set; }

        [Required]
        public DateTime TimeRecieved { get; set; }

        [Required]
        public DateTime Timestamp { get; set; }
    }
}
