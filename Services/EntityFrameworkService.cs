 using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Context;
using Entities;
using Repositories;
using Validataors;

namespace Services
{
    public class EntityFrameworkService : IEntityFrameworkService

    {
        IEFRepository eFRepository = new EFRepository();

        public int Create (PersonEntity personEntity)
        {
            var rowsAffected = eFRepository.Create(personEntity);
            Validataors.ObjectValidator.ValidateRowsAffected(rowsAffected);
            return RowsAffected(rowsAffected);
        }

        public PersonEntity GetById (int personID)
        {
            return eFRepository.GetById(personID);
        }
        public int Edit (PersonEntity personEntity)
        {
            var data = eFRepository.GetById(personEntity.PersonID);
            var rowsAffected = eFRepository.Edit(data);
            return RowsAffected(rowsAffected);
        }

        public IEnumerable<PersonEntity> GetAll()
        {
            var personEntities = eFRepository.GetAll();
            Validataors.ObjectValidator.IsGreaterThanZero(personEntities);
            return personEntities;
        }

        public int Delete (int personID)
        {
            var rowsAffected = eFRepository.Delete(personID);
            return RowsAffected(rowsAffected);    
        }

        private int RowsAffected(int rowsAffected)
        {
            if (rowsAffected > 0)
            {
                return rowsAffected;
            }
            else
            {
                return 0;
            }
        }
    }
}







