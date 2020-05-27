using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoronaApp.Services;

using Microsoft.EntityFrameworkCore;
using CoronaApp.Dal;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoronaApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {

        public ILocationRepository LocationRepository;
        public LocationController(ILocationRepository locationRepository)
        {
            LocationRepository = locationRepository;
        }
        // GET: api/<LocationController>

        [HttpGet]
       [Route("{action}")]
        public IActionResult GetAllList()
        {
            var listPatient = new List<Location>();
            CoronaContext context = new CoronaContext();

            foreach (var item in context.Patient.Include(x => x.Path))
            {
                foreach (var item2 in item.Path)
                {
                    listPatient.Add(item2);
                }
            }
            return Ok(listPatient);
        }
        [HttpGet]
        //[Route("{action}")]
        public IEnumerable<Location> Get([FromQuery] LocationSearch locationSearch=null)
        {
            var listDemo = LocationRepository.Get(locationSearch);
            return listDemo;
        }

        [HttpGet]
       [Route("action/{id}")]
        public string Geta(string id)
        {
            return ("freg");
        }

    }
}
