﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CincyCarsAndCoffee.Models
{
    public class South
    {
        public South() { }
        public int Id { get; set; }
        [StringLength(40), Required]
        public string Name { get; set; }
        [StringLength(40), Required]
        public string Organization { get; set; }
        [StringLength(200), Required]
        public string Location { get; set; }
        [StringLength(40), Required]
        public string Time { get; set; }
        [StringLength(200)]
        public string Link { get; set; }


    }
}
