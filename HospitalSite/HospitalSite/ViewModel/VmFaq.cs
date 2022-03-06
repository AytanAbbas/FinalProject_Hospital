using HospitalSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.ViewModel
{
    public class VmFaq:VmLayout
    {
        public List<Faq> Faqs { get; set; }
        public Banner Banner { get; set; }
    }
}
