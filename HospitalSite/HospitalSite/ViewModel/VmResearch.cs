using HospitalSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.ViewModel
{
    public class VmResearch : VmLayout
    {
        public List<Research> Researches { get; set; }
        public List<ResearchImage> ResearchImages { get; set; }
        public Category Category { get; set; }
        public Banner Banner { get; set; }
        public Research ResearchDetail { get; set; }

    }
}