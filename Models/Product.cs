using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace seanoneill.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
   
        public double Price { get; set; } = 0.0;
        public string Description { get; set; }

        public string CreationDate { get; set; }
        public string ExpiredDate { get; set; }

    }
}
