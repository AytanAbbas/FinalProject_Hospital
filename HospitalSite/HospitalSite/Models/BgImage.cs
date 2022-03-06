using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.Models
{
    public class BgImage
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string TestimonialBgImage { get; set; }
        [NotMapped]
        public IFormFile TestimonialBgImageFile { get; set; }
        [MaxLength(250)]
        public string AccordionBgImage { get; set; }
        [NotMapped]
        public IFormFile AccordionBgImageFile { get; set; }
        [MaxLength(250)]
        public string ServiceBgImage { get; set; }
        [NotMapped]
        public IFormFile ServiceBgImageFile { get; set; }
        [MaxLength(250)]
        public string FutureBgImage { get; set; }
        [NotMapped]
        public IFormFile FutureBgImageFile { get; set; }
    }
}
