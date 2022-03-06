using HospitalSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.ViewModel
{
    public class VmHome:VmLayout
    {
        public List<HomeSlider> HomeSliders { get; set; }
        public List<Future> Futures { get; set; }
        public Service Service { get; set; }
        public List<ServiceTip> ServiceTips { get; set; }
        public BgImage BgImage { get; set; }
        public List<Research> Researches { get; set; }
        public List<Testimonial> Testimonials{ get; set; }
        public List<Partner> Partners { get; set; }
        public List<Accordion> Accordions { get; set; }
        public List<FidSection> FidSections { get; set; }
        public List<ProcessPlan> ProcessPlans { get; set; }
        public List<Category> Categories { get; set; }
        public List<AboutResearch> AboutResearches { get; set; }


    }
}
