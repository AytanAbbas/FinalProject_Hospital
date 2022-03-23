using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.Models
{
    public class WorkProcess
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250), Required]
        public string BgImage { get; set; }
        [NotMapped]
        public IFormFile BgImageFile { get; set; }
        [MaxLength(250), Required]
        public string About { get; set; }
    }
}
