using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.Models
{
    public class ServiceTexnoLab
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250), Required]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [MaxLength(150), Required]
        public string Title { get; set; }
        [MaxLength(400), Required]
        public string About { get; set; }
        [MaxLength(150), Required]
        public string FooterTitle { get; set; }
    }
}
