﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.Models
{
    public class CustomUser : IdentityUser
    {
        [MaxLength(250), Required]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [MaxLength(30), Required]
        public string Name { get; set; }
        [MaxLength(30), Required]
        public string Surname { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<Blog> Blogs { get; set; }
        [NotMapped]
        public string RoleId { get; set; }
    }
}
