using HospitalSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.ViewModel
{
    public class VmAllSearch :VmTeam
    {
        public List <Team> Teams { get; set; }
         public VmSearch Search { get; set; }
    }
}
