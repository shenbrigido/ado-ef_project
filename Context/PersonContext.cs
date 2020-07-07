using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public class PersonContext : DbContext
    {
        public PersonContext() : base("NewDatabase") { }
        public DbSet<PersonEntity> Person { get; set; }
        public DbSet<AddressEntity> Address { get; set; }
        public DbSet<DemographicsEntity> Demographics { get; set; }
    }
}
