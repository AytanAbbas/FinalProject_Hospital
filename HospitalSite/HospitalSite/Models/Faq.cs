using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.Models
{
    public class Faq
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100), Required]
        public string Question { get; set; }

        [MaxLength(1500),Required]
        public string Answer { get; set; }
    }
}
