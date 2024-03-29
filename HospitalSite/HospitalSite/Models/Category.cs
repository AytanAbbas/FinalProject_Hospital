﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100), Required]
        public string Name { get; set; }
        public List<Research> Researches { get; set; }

    }
}
