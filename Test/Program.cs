using Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        public static void Main(string[] args)
        {
            //    var personEntity = new PersonEntity();
            //    personEntity.FamilyName = "Pane";
            //    personEntity.FirstName = "Hans";

            //    var addressEntity = new AddressEntity();
            //    addressEntity.AddressLine = "#23 Maple Street, Oum drive";
            //    addressEntity.City = "Los Angeles, CA";
            //    addressEntity.Zipcode = 2464;
            //    var demographicsEntity = new DemographicsEntity();
            //    demographicsEntity.Age = 12;

            //    personEntity.Address = addressEntity;
            //    personEntity.Demographics = demographicsEntity;



            //    //var isSuccess = GetAllNames();
            //    //if (isSuccess == "Success")
            //    //{
            //    //    Console.WriteLine("Successful Printing");
            //    //    Console.ReadLine();
            //    //}
            //    //else
            //    //{
            //    //    Console.WriteLine("Failure Printing");
            //    //    Console.ReadLine();
            //    //}
            //    //var isAddSuccess = AddName(personEntity);
            //    //if (isAddSuccess == 1)
            //    //{
            //    //    Console.WriteLine("Add Successful");
            //    //    Console.ReadLine();
            //    //}
            //    //else
            //    //{
            //    //    Console.WriteLine("Add Failure");
            //    //    Console.ReadLine();
            //    //}

            //    //var isEditSuccess = EditPerson(personEntity);
            //    //if (isEditSuccess == 1)
            //    //{
            //    //    Console.WriteLine("Edit Successful");
            //    //    Console.ReadLine();
            //    //}
            //    //else
            //    //{
            //    //    Console.WriteLine("Edit Failure");
            //    //    Console.ReadLine();
            //    //}
            //    //var isDeleteSuccess = DeletePerson(personEntity);
            //    //if (isDeleteSuccess == 1)
            //    //{
            //    //    Console.WriteLine("Deleted Successfully");
            //    //    Console.ReadLine();
            //    //}
            //    //else
            //    //{
            //    //    Console.WriteLine("Delete Not Successful");
            //    //    Console.ReadLine();
            //    //}


            //    var isEditStudentSuccess = EditPersonData(personEntity);
            //    if (isEditStudentSuccess >= 1)
            //    {
            //        Console.WriteLine("Edit Person Successful. Press enter to exit..");
            //        Console.ReadLine();
            //    }
            //    else
            //    {
            //        Console.WriteLine("Edit Person Failure");
            //        Console.ReadLine();
            //    }

            //    var isGetSuccess = DisplayPesondata();
            //    if (isGetSuccess >= 1)
            //    {
            //        Console.WriteLine("Get Person Data Successful. Press enter to exit..");
            //        Console.ReadLine();
            //    }
            //    else
            //    {
            //        Console.WriteLine("Get Person Data Failure");
            //        Console.ReadLine();
            //    }

            //    var isDeleteStudentSuccess = DeletePersonData(personEntity);
            //    if (isDeleteStudentSuccess >= 1)
            //    {
            //        Console.WriteLine("Delete Person Successful. Press enter to exit..");
            //        Console.ReadLine();
            //    }
            //    else
            //    {
            //        Console.WriteLine("Delete Person Failure");
            //        Console.ReadLine();
            //    }
            //}



            ////public static string GetAllNames()
            ////{
            ////    var adonetService = new ADONETService();
            ////    var persons = adonetService.GetAllNames();
            ////    if (persons == null)
            ////    {
            ////        return null;
            ////    }
            ////    else
            ////    {
            ////        foreach (var person in persons)
            ////        {
            ////            Console.WriteLine("First Name {0}, Family Name {1}", person.FirstName, person.FamilyName);
            ////        }
            ////        Console.ReadLine();
            ////        return "Success";
            ////    }
            ////}
            ////public static int AddName(PersonEntity personEntity)
            ////{
            ////    var adonetService = new ADONETService();
            ////    var persons = adonetService.AddName(personEntity);

            ////    Console.WriteLine("First Name {0}, Family Name {1}", personEntity.FirstName, personEntity.FamilyName);

            ////    //var adonetService = new ADONETService();
            ////    //var persons = adonetService.AddName(personEntity.FirstName, personEntity.FamilyName);
            ////    return persons;
            ////}
            ////public static int EditPerson(PersonEntity personEntity)
            ////{

            ////    var adonetService = new ADONETService();
            ////    var persons = adonetService.EditPerson(personEntity);
            ////    return persons;

            ////}
            ////public static int DeletePerson(PersonEntity personEntity)
            ////{
            ////    var adonetService = new ADONETService();
            ////    var persons = adonetService.DeletePerson(personEntity.PersonID);
            ////    return persons;
            ////}
            //public static int CreatePersonData(PersonEntity personEntity)
            //{
            //    Console.Write("Creating Person Database. ");
            //    var entityFrameworkService = new EntityFrameworkService();
            //    var person = entityFrameworkService.CreatePerson(personEntity);
            //    return person;
            //}
            //public static int EditPersonData(PersonEntity personEntity)
            //{
            //    Console.Write("Editing Person in Database. ");          
            //    var entityFrameworkService = new EntityFrameworkService();
            //    var person = entityFrameworkService.EditPerson(personEntity.PersonID);
            //    return person;
            //}
            //public static IEnumerable<PersonEntity> GetPersonData()
            //{
            //    Console.WriteLine("Displaying List of Persons");

            //    var entityFrameworkService = new EntityFrameworkService();

            //    return entityFrameworkService.GetPerson();
            //}

            //public static int DisplayPesondata()
            //{
            //    var people = GetPersonData();
            //    if (people.Count() > 0)
            //    {
            //        foreach (var person in people)
            //        {
            //            Console.WriteLine("First Name {0}, Family Name {1}", person.FirstName, person.FamilyName);
            //            Console.WriteLine("Address {0}, Demographics {1}", person.Address.AddressLine, person.Demographics.Age);
            //        }
            //        return 1;
            //    }
            //    else
            //    {

            //        return 0;
            //    }          
            //}

            //public static int DeletePersonData(PersonEntity personEntity)
            //{
            //    Console.WriteLine("Removing Person from the database");
            //    var entityFrameworkService = new EntityFrameworkService();
            //    var person = entityFrameworkService.DeletePerson(personEntity.PersonID);
            //    return person;
            //}
        }
    }
}
