using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IEFRepository
    {
        int Create (PersonEntity personEntity);
        PersonEntity GetById(int personID);
        int Edit (PersonEntity personEntity);
        IEnumerable<PersonEntity> GetAll ();
        int Delete (int PersonID);
     
    }
}
