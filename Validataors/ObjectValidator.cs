using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validataors
{
    public static class ObjectValidator
    {
        public static void ValidateIsCreateSuccess(int isCreateSuccess)
        {
            if (isCreateSuccess == 0)
            {
                throw new Exception();
            }
        }

        public static void IsNotNull(object person)
        {
            if (person == null)
            {
                throw new Exception();
            }
        }

        public static void ValidateRowsAffected(int rowsAffected)
        {
            if (rowsAffected == 0)
            {
                throw new Exception();
            }
        }

        public static void FindID(PersonEntity findID)
        {
            if (findID == null)
            {
                throw new Exception();
            }
        }

        public static void IsEditSuccess(int isEditSuccess)
        {
            if (isEditSuccess == 0)
            {
                throw new Exception();
            }
        }

        public static void IsGreaterThanZero(IEnumerable<PersonEntity> personEntities)
        {
            if (personEntities.Count() < 0)
            {
                throw new Exception();
            }
        }

        public static void IsDeleteSuccess(int isDeleteSuccess)
        {
            if (isDeleteSuccess == 0)
            {
                throw new Exception();
            }
        }
    }
}
