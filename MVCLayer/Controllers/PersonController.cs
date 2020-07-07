using Context;
using DataObjects;
using Entities;
using Services;
using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;


namespace MVCLayer.Controllers
{
    [RoutePrefix("api/person")]
    public class PersonController : ApiController
    {
        IEntityFrameworkService entityFrameworkService = new EntityFrameworkService();

        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("create")]
        public IHttpActionResult Create(PersonDTO personDTO)
        {
            Validataors.ObjectValidator.IsNotNull(personDTO);
            var isCreateSuccess = entityFrameworkService.Create(ConvertToPersonEntity(personDTO));
            Validataors.ObjectValidator.ValidateIsCreateSuccess(isCreateSuccess);
            return Ok(isCreateSuccess);
        }

        public IHttpActionResult GetById (int personID)
        {
            Validataors.ObjectValidator.IsNotNull(personID);
            var person = entityFrameworkService.GetById(personID);
            Validataors.ObjectValidator.IsNotNull(person);
            return Ok(person);
        }

        [System.Web.Http.HttpPut]
        [System.Web.Http.Route("Edit")]
        public IHttpActionResult Edit(PersonDTO personDTO)
        {
            Validataors.ObjectValidator.IsNotNull(personDTO);
            var isEditSuccess = entityFrameworkService.Edit(ConvertToPersonEntity(personDTO));
            Validataors.ObjectValidator.IsEditSuccess(isEditSuccess);
            return Ok(isEditSuccess); 

        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("GetAll")]
        public IHttpActionResult GetAll()
        {
            var person = entityFrameworkService.GetAll();
            return Ok(person);
        }

        [System.Web.Http.HttpDelete]
        [System.Web.Http.Route("Delete/{id}")]
        public IHttpActionResult Delete(int id)
        {
            Validataors.ObjectValidator.IsNotNull(id);
            var isDeleteSuccess = entityFrameworkService.Delete(id);
            // add validator
            Validataors.ObjectValidator.IsDeleteSuccess(isDeleteSuccess);
            return Ok(isDeleteSuccess);
        }

        private PersonEntity ConvertToPersonEntity(PersonDTO personDTO)
        {
            var personEntity = new PersonEntity()
            {
                PersonID = Convert.ToInt32(personDTO.PersonID),
                FamilyName = personDTO.FamilyName,
                FirstName = personDTO.FirstName
            };

            //var demographicsEntity = new DemographicsEntity()
            //{
            //    DemographicsID = Convert.ToInt32(personDTO.DemographicsID),
            //    Age = Convert.ToInt32(personDTO.Age),
            //};
            //var addressEntity = new AddressEntity()
            //{
            //    AddressID = Convert.ToInt32(personDTO.AddressID),
            //    AddressLine = (personDTO.AddressLine),
            //    City = personDTO.City,
            //    Zipcode = Convert.ToInt32(personDTO.Zipcode)
            //};
            //personEntity.Address = addressEntity;
            //personEntity.Demographics = demographicsEntity;
            return personEntity;
        }

    }
}








