using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250), Required]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [MaxLength(50), Required]
        public string Fullname { get; set; }
        [MaxLength(50), Required]
        public string Position { get; set; }
        [MaxLength(30), Required]
        public string Phone { get; set; }
       
        [MaxLength(30), Required]
        public string CabinNumber { get; set; }
        [Column(TypeName = "ntext"), Required]
        public string Biography { get; set; }
        [MaxLength(30), Required]
        public string Experience { get; set; }
        [MaxLength(50), Required]
        public string Email { get; set; }
        [MaxLength(250), Required]
        public string Certification { get; set; }
        [MaxLength(250), Required]
        public string PracticeArea { get; set; }
        [ForeignKey("University")]
        public int UniversityId { get; set; }
        public University University { get; set; }
        public List<TeamSocial> TeamSocials { get; set; }
       
        public List<TeamExperience> TeamExperiences { get; set; }
        [NotMapped]
        public List<int> TeamExperiencesId { get; set; }
        [NotMapped]
        public List<int> TeamExperience { get; set; }
        public List<SkillToTeam> SkillToTeams { get; set; }
        public List<Appointment> Appointments { get; set; }
        [NotMapped]
        public List<int> SkillToTeamsId { get; set; }
        [NotMapped]
        public List<int> Skill { get; set; }
  
     


    }
}
