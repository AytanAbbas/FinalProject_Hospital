using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.Models
{
    public class WorkExperience
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250), Required]
        public string Icon { get; set; }
        [MaxLength(30), Required]
        public string Title { get; set; }
        [MaxLength(500), Required]
        public string About { get; set; }
        public List<TeamExperience> TeamExperiences { get; set; }
    }
}
