using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.Models
{
    public class TeamExperience
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Team")]
        public int TeamId { get; set; }
        public Team Team { get; set; }

        [ForeignKey("WorkExperience")]
        public int WorkExperienceId { get; set; }
        public WorkExperience WorkExperience { get; set; }
    }
}
