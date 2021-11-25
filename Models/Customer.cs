using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CofffeeLovers.Models
{
    public class Customer
    {
        [Required, StringLength(maximumLength: 15)]
        public string FirstName { get; set; }

        [Required]
        public int ID { get; set; }

        [Required, StringLength(maximumLength: 15)]
        public string LastName { get; set; }

        [Required, StringLength(maximumLength: 30)]
        public string Email { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public Boolean UnderAge { get; set; }

        [Required, StringLength(maximumLength: 30)]
        public string Address { get; set; }
    }
}
