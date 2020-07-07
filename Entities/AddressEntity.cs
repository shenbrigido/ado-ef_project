using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class AddressEntity
    {     
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressID { get; set; }
        public string AddressLine { get; set; }
        public string City { get; set; }
        public int Zipcode { get; set; }
        public ICollection<PersonEntity> Person { get; set; }
        public ICollection<DemographicsEntity> Demographics { get; set; }
    }
}
