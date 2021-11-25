using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CofffeeLovers.Models
{
    public class Address
    {
        [Required]
        public int AddressID { get; set; }

        [Required, StringLength(maximumLength: 30)]
        public string Line1Address { get; set; }

        [Required, StringLength(maximumLength: 15)]
        public string City { get; set; }

        [StringLength(maximumLength: 30)]
        public string Line2Address { get; set; }

        public int AddressID2 { get; set; }

        [Required, StringLength(maximumLength: 7)]
        public string Postcode { get; set; }
    }
}
