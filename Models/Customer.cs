using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace seanoneill.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string Fname { get; set; }
        [Required]
        public string Lname { get; set; }
        [Required]

        public string Address { get; set; }
        [Required]
        public int Phone { get; set; }
    }
}
