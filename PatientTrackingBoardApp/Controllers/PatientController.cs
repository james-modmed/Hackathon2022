using Microsoft.AspNetCore.Mvc;
using PatientTrackingBoardApp.Services.Board;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PatientTrackingBoardApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly BoardService _boardService;

        public PatientController(BoardService boardService)
        {
            _boardService = boardService;
        }

        [HttpGet("AddPatient/{firstName}/{lastName}/{sourceId}")]
        public void AddPatient(string firstName, string lastName, string sourceId)
        {
        }

        [HttpGet("DeletePatientById/{id}")]
        public void DeletePatientById(string id)
        {
        }

        [HttpGet("DeletePatientBySourceId/{sourceId}")]
        public void DeletePatientBySourceId(string sourceId)
        {
        }

        [HttpGet("UpdatePatientById/{id}/{firstName}/{lastName}/{sourceId}")]
        public void UpdatePatientById(Guid id, string firstName, string lastName, string sourceId)
        {
        }

        [HttpGet("UpdatePatientBySourceId/{sourceId}/{firstName}/{lastName}")]
        public void UpdatePatientBySourceId(string sourceId, string firstName, string lastName)
        {
        }
    }
}