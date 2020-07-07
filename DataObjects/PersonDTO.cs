using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class PersonDTO
    {
        public string PersonID { get; set; }
        public string FamilyName { get; set; }
        public string FirstName { get; set; }
        public DemographicsDTO DemographicsDTO { get; set; }
        public AddressDTO AddressDTO { get; set; }
    }
}

