using Microsoft.AspNetCore.Mvc;
using PatientTrackingBoardApp.Services.Board;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PatientTrackingBoardApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly BoardService _boardService;

        public LocationController(BoardService boardService)
        {
            _boardService = boardService;
        }

        [HttpGet("AddLocation/{name}")]
        public void AddLocation(string name)
        {
        }

        [HttpGet("DeleteLocation/{name}")]
        public void DeleteLocation(string name)
        {
        }

        [HttpGet("UpdateLocation/{currentName}/{newName}")]
        public void UpdateLocation(string sourceId)
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