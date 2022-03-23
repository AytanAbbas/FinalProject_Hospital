using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.Models
{
    public class Testimonial
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250), Required]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [MaxLength(100), Required]
        public string Quote { get; set; }
        [MaxLength(500), Required]
        public string Description { get; set; }
        [MaxLength(60), Required]
        public string Fullname { get; set; }
        [MaxLength(60), Required]
        public string Profession { get; set; }
    }
}
