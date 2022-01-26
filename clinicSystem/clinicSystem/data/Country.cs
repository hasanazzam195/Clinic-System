using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace clinicSystem.data
{
    [Table("Countries")]
    public class Country
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string code { get; set; }

        public List<Patient> lipatient { get; set; }
    }
}
