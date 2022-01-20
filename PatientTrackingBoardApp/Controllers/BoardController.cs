using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PatientTrackingBoardApp.Data;
using PatientTrackingBoardApp.Data.Tracking;
using Visit = PatientTrackingBoardApp.Data.Tracking.Visit;
using Patient = PatientTrackingBoardApp.Data.Tracking.Patient;
using Provider = PatientTrackingBoardApp.Data.Tracking.Provider;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PatientTrackingBoardApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardController : ControllerBase
    {
        private readonly PatientTrackingBoardDBContext _dbContext;

        public BoardController(PatientTrackingBoardDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/<ValuesController>
        [HttpGet("InternalBoard")]
        public IEnumerable<Visit> GetInternalBoard(Guid locationId)
        {
            return _dbContext.Visits.Select(p => new Visit
            {
                Patient = new Patient
                {
                    FirstName = p.Patient.FirstName,
                    LastName = p.Patient.LastName
                },
                CurrentPhysician = new Provider
                {
                    FirstName = p.Provider.FirstName,
                    LastName = p.Provider.LastName
                },
            });
        }

        [HttpGet("ExternalBoard")]
        public IEnumerable<Visit> GetExternalBoard(Guid locationId)
        {
            return _dbContext.Visits.Select(p => new Visit
            {
                Patient = new Patient
                {
                    FirstName = p.Patient.FirstName,
                    LastName = p.Patient.LastName
                },
                CurrentPhysician = new Provider
                {
                    FirstName = p.Provider.FirstName,
                    LastName = p.Provider.LastName
                },
            });
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
