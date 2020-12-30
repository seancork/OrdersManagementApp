using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace seanoneill.Models
{
    public class Status
    {
        public int StatusId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
