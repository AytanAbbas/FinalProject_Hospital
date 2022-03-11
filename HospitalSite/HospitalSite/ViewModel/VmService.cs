using HospitalSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.ViewModel
{
    public class VmService : VmLayout
    {
        public Banner Banner { get; set; }
        public ServiceAbout ServiceAbout { get; set; }
        public BgImage BgImage { get; set; }
        public List<ServiceTip> ServiceTips { get; set; }
        public List<Future> Futures { get; set; }
        public List<Research> Researches { get; set; }
        public List<ResearchImage> ResearchImages { get; set; }
        public List<Partner> Partners { get; set; }
        public List<Category> Categories { get; set; }



    }
}
