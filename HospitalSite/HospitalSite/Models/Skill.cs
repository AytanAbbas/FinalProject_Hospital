using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.Models
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(150), Required]
        public string Name { get; set; }

        [MaxLength(30), Required]
        public string Percent { get; set; }
        public List<SkillToTeam> SkillToTeams { get; set; }
    }
}
