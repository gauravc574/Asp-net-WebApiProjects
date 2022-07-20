using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web_Api_Demo.Models.Context;

namespace Web_Api_Demo.Controllers
{
    public class HomeController : ApiController
    {
        //Creating Instance of DatabaseContext class
        private AppDbContext db = new AppDbContext();

        //Method to return Json Data

        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                //Prepare data to be returned using LINQ as follow
                var result = from country in db.Countries
                             select new
                             {
                                 country.CountryId,
                                 country.Name,
                                 State = from state in db.States
                                         where state.CountryId == country.CountryId
                                         select new {
                                            state.StateId,
                                            state.Name,
                                            City = from city in db.Cities
                                                   where city.StateId == state.StateId
                                                   select new { 
                                                        city.CityId,
                                                        city.Name
                                                   }
                                         }
                             };

                return Ok(result);
            }
            catch (Exception)
            {

                //If any exception occurs Internal Server Error i.e 500 code

                return InternalServerError();
            }
        }
    }
}
