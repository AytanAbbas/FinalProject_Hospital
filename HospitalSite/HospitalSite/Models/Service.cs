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
        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [MaxLength(500)]
        public string Content { get; set; }
        [MaxLength(30)]
        public string Phone { get; set; }
        [MaxLength(20)]
        public string Experience { get; set; }
        [MaxLength(80)]
        public string Title { get; set; }
       

    }
}
