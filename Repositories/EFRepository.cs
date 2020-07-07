using Context;
using Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;


namespace Repositories
{
    public class EFRepository : IEFRepository
    {
        PersonContext personContext = new PersonContext();

        public int Create(PersonEntity personEntity)
        {
            personContext.Person.Add(personEntity);
            int rowsAffected = personContext.SaveChanges();
            Validataors.ObjectValidator.ValidateRowsAffected(rowsAffected);
            return rowsAffected;

        }
        public PersonEntity GetById(int personID)
        {
            var findID = personContext.Person.Find(personID);
            Validataors.ObjectValidator.FindID(findID);
            return findID;
        }

        public int Edit(PersonEntity personEntity)
        {
            personContext.Entry(personEntity).State = EntityState.Modified;
            var rowsAffected = personContext.SaveChanges();
            Validataors.ObjectValidator.ValidateRowsAffected(rowsAffected);
            return rowsAffected;

        }
        public IEnumerable<PersonEntity> GetAll()
        {
            return personContext.Person
                .Include("Address")
                .Include("Demographics")
                .ToList();
        }

        public int Delete(int personID)
        {
            var personEntity = personContext.Person.Find(personID);
            personContext.Person.Remove(personEntity);
            var rowsAffected = personContext.SaveChanges();
            Validataors.ObjectValidator.ValidateRowsAffected(rowsAffected);
            return rowsAffected;

        }
    }


}
