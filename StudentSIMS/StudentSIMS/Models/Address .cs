using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StudentSIMS.Models
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressId { get; set; }
        public int streetNumber { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string postCode { get; set; }
        public string country{ get; set; }
        public int studentId { get; set; }

        public virtual Student Student { get; set; }
    }
}
