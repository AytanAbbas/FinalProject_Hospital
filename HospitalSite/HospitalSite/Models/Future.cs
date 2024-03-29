﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.Models
{
    public class Future
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50), Required]
        public string Icon { get; set; }
        [MaxLength(50), Required]
        public string Title { get; set; }
        [MaxLength(500),Required]
        public string Description { get; set; }
    }
}
