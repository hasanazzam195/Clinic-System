using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace clinicSystem.data
{
    [Table("Patients")]
    public class Patient
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime BDate { get; set; }
        public string gender { get; set; }

        [ForeignKey("country")]
        public int Country_id { get; set; }
        public Country country { get; set; }
    }
}
