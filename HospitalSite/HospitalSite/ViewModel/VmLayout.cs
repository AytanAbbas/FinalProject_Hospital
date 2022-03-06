using HospitalSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.ViewModel
{
    public class VmLayout
    {
        public Setting Setting { get; set; }
        public List<SiteSocial> SiteSocials { get; set; }
        public Subscribe Subscribe { get; set; }
        public List<Research> Researches { get; set; }
        public Appointment Appointment { get; set; }
        public List<Team> Teams { get; set; }


    }

}
