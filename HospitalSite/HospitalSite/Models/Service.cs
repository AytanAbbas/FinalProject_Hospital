using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250), Required]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [MaxLength(500), Required]
        public string Content { get; set; }
        [MaxLength(30), Required]
        public string Phone { get; set; }
        [MaxLength(20), Required]
        public string Experience { get; set; }
        [MaxLength(80), Required]
        public string Title { get; set; }
       

    }
}
