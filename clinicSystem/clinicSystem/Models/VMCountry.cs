using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using clinicSystem.data;

namespace clinicSystem.Models
{
    public class VMCountry
    {
        public Country  country { get; set; }
        public List<Country> licountry { get; set; }
    }
}
