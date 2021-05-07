﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CCaC.Models
{
    public class North
    {
        public North() { }
        public int Id { get; set; }
        [StringLength(50), Required]
        public string Name { get; set; }
        [StringLength(50), Required]
        public string Organization { get; set; }
        [StringLength(40), Required]
        public DateTime Date { get; set; }
        [StringLength(40), Required]
        public TimeSpan Time { get; set; }
        [StringLength(255)]
        public string Link { get; set; }
    }
}
