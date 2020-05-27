
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoronaApp.Services;
using CoronaApp.Dal;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoronaApp.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        public IPatientRepository PatientRepository;
        public PatientController(IPatientRepository patientRepository)
        {
            PatientRepository = patientRepository;
        }
        // GET api/<PatientController>/5
        [HttpGet("{id}")]
        public object Get(int id)
        {
            return PatientRepository.Get(id);
        }

        // POST api/<PatientController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            PatientRepository.Save(new Dal.Patient(int.Parse(value)));
        }

        // PUT api/<PatientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Location location)
        {
            PatientRepository.Add(id, location);

        }

        [HttpDelete("{id}")]
        public void Delete(int id, [FromBody] Location location)
        {
            PatientRepository.Delete(id, location);

        }


    }
}












//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using CoronaApp.Services;
////using CoronaApp.Dal;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace CoronaApp.Api.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class PatientController : ControllerBase
//    {
//        public IPatientRepository PatientRepository;
//        public PatientController(IPatientRepository patientRepository)
//        {
//            PatientRepository = patientRepository;
//        }
//        // GET api/<PatientController>/5
//        [HttpGet("{id}")]
//        public object Get(string id)
//        {
//            return id;
//        }

//        // POST api/<PatientController>
//        [HttpPost]
//        public void Post([FromBody] string value)
//        {

//        }

//        // PUT api/<PatientController>/5
//        [HttpPut("{id}")]
//        public void Put(int id, [FromBody] string value)
//        {
//        }


//    }
//}

