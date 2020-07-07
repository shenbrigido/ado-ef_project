using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class DemographicsEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DemographicsID { get; set; }
        public  int Age { get; set; }
        public ICollection<PersonEntity> Person { get; set; }
        public ICollection<AddressEntity> Address { get; set; }

    }
}
