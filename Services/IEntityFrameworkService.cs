using Entities;
using System.Collections.Generic;

namespace Services
{
    public interface IEntityFrameworkService
    {
        int Create (PersonEntity personEntity);
        PersonEntity GetById(int personID);
        int Edit(PersonEntity personEntity);
        IEnumerable<PersonEntity> GetAll ();
        int Delete (int personID);

    }
}


        
       