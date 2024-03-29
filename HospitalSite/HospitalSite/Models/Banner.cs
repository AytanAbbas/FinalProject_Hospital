﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.Models
{
    public class Banner
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200), Required]
        public string Title { get; set; }
        [MaxLength(50), Required]
        public string SubTitle { get; set; }

        [MaxLength(50), Required]
        public string Page { get; set; }
       
    }
}
