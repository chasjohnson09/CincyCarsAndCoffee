using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Init_Project.Models
{
    public class West
    {
        public West() { }
        public int Id { get; set; }
        [StringLength(200), Required]
        public string Name { get; set; }
        [StringLength(200), Required]
        public string Organization { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [StringLength(500)]
        public string Link { get; set; }
    }
}
