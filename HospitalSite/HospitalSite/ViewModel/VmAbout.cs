using HospitalSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.ViewModel
{
    public class VmAbout:VmLayout
    {
        public Banner Banner { get; set; }
        public Choose Choose { get; set; }
        public List<ChooseUs> ChooseUs { get; set; }
        public List<FidSection> FidSections { get; set; }
        public WorkProcess WorkProcess { get; set; }
        public List<ProcessPlan> ProcessPlans { get; set; }
        public List<Team> Teams { get; set; }
        public List<TeamSocial> TeamSocials { get; set; }
    }
}
