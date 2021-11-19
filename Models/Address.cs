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
        [Required]
        public string Line1Address { get; set; }
        [Required]
        public string City { get; set; }
        public string Line2Address { get; set; }
        public int AddressID2 { get; set; }
        [Required]
        public string Postcode { get; set; }
    }
}
