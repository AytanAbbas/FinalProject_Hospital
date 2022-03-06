using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.Models
{
    public class Research
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string MainImage { get; set; }
        [NotMapped]
        public IFormFile MainImageFile { get; set; }
        [MaxLength(250)]
        public string DetailImage { get; set; }
        [NotMapped]
        public IFormFile DetailImageFile { get; set; }
        [MaxLength(500)]
        public string Title { get; set; }
        [MaxLength(30)]
        public string Client { get; set; }
        public DateTime CreatedDate { get; set; }
        [MaxLength(150)]
        public string Location { get; set; }
        [Column(TypeName = "ntext"), Required]
        public string Details { get; set; }
        [Column(TypeName = "ntext"), Required]
        public string Advantages { get; set; }
        public List<ResearchImage> ResearchImages { get; set; }

        [ForeignKey("Category")]
        public int CatId { get; set; }
        public Category Category { get; set; }
    }
}
