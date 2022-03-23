﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.Models
{
    public class ServiceTip
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250), Required]
        public string Name { get; set; }
       

    }
}
