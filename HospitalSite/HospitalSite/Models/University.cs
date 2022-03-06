using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.Models
{
    public class University
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250), Required]
        public string Medical { get; set; }
        [MaxLength(250), Required]
        public string Residency { get; set; }
        public List<Team> Teams { get; set; }

    }
}
