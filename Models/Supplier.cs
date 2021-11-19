using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CofffeeLovers.Models
{
    public class Supplier
    {
        [Required]
        public String Name { get; set; }
        [Required]
        public decimal Contact { get; set; }
        [Required]
        public String Email { get; set; }
    }
}
