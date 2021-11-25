using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CofffeeLovers.Models
{
    public class Supplier
    {
        [Required, StringLength(maximumLength: 15)]
        public String Name { get; set; }

        [Required, StringLength(maximumLength: 10)]
        public decimal Contact { get; set; }

        [Required, StringLength(maximumLength: 30)]
        public String Email { get; set; }
    }
}
