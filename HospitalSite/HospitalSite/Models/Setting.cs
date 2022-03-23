using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(255), Required]
        public string Logo { get; set; }
        [NotMapped]
        public IFormFile LogoFile { get; set; }
        [MaxLength(255), Required]
        public string FooterBgImage { get; set; }
        [NotMapped]
        public IFormFile FooterBgImageFile { get; set; }
        [MaxLength(250), Required]
        public string Signature { get; set; }
        [NotMapped]
        public IFormFile SignatureFile { get; set; }

        [MaxLength(20), Required]
        public string Phone1 { get; set; }

        [MaxLength(20), Required]
        public string Phone2 { get; set; }

        [MaxLength(50), Required]
        public string Email1 { get; set; }

        [MaxLength(50), Required]
        public string Email2 { get; set; }
        [MaxLength(200), Required]
        public string Address { get; set; }
        [MaxLength(300), Required]
        public string Info { get; set; }
        [MaxLength(500), Required]
        public string About { get; set; }
        [MaxLength(255), Required]
        public string AboutImage { get; set; }
        [NotMapped]
        public IFormFile AboutImageFile { get; set; }
        [MaxLength(30), Required]
        public string Foundername { get; set; }
        [MaxLength(30), Required]
        public string Founderposition { get; set; }
        [MaxLength(250), Required]
        public string WorkHours { get; set; }
        [MaxLength(300), Required]
        public string MapLink { get; set; }



    }
}
