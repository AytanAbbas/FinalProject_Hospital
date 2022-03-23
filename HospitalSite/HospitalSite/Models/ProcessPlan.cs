using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.Models
{
    public class ProcessPlan
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150), Required]
        public string Title { get; set; }
        [MaxLength(150), Required]
        public string Icon { get; set; }
        [MaxLength(10), Required]
        public string Number { get; set; }
        [MaxLength(250), Required]
        public string Content { get; set; }
        [MaxLength(250), Required]
        public string ArrowImage { get; set; }
        [NotMapped]
        public IFormFile ArrowImageFile { get; set; }
    }
}
