using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSIMS
{
    public class AddressModel
    {
        public int AddressId { get; set; }
        public int streetNumber { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string postCode { get; set; }
        public string country { get; set; }

        public int studentId { get; set; }
    }
}
