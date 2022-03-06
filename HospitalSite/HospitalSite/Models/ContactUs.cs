using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.Models
{
    public class ContactUs
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50), Required]
        public string Name { get; set; }
        [MaxLength(100), Required]
        public string Email { get; set; }
        [MaxLength(30), Required]
        public string Phone { get; set; }
        [MaxLength(200), Required]
        public string Subject { get; set; }
        [Column(TypeName = "ntext"), Required]
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
