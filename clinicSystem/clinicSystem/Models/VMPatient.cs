using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using clinicSystem.data;

namespace clinicSystem.Models
{
    public class VMPatient
    {
        public Patient patient { get; set; }
        public List<Country> licountry { get; set; }
    }

}
