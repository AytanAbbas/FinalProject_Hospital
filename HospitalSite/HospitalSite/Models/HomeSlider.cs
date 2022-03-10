using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.Models
{
    public class HomeSlider
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [MaxLength(250)]
        public string LeftImage { get; set; }
        [NotMapped]
        public IFormFile LeftImageFile { get; set; }
        [MaxLength(250)]
        public string RightImage { get; set; }
        [NotMapped]
        public IFormFile RightImageFile { get; set; }
        [MaxLength(150)]
        public string Title { get; set; }
        [MaxLength(500)]
        public string Link { get; set; }
    }
}
