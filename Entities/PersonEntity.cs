using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PersonEntity
    {
        // test
        // shen exams
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonID { get; set; }
        public string FamilyName { get; set; }
        public string FirstName { get; set; }
        public virtual DemographicsEntity Demographics { get; set; }
        public virtual AddressEntity Address { get; set; }

    }
}
