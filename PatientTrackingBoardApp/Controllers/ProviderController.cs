using Microsoft.AspNetCore.Mvc;
using PatientTrackingBoardApp.Services.Board;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PatientTrackingBoardApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProviderController : ControllerBase
    {
        private readonly BoardService _boardService;

        public ProviderController(BoardService boardService)
        {
            _boardService = boardService;
        }

        [HttpGet("AddPatient/{firstName}/{lastName}/{displayName}")]
        public void AddProvider(string firstName, string lastName, string displayName)
        {
        }

        [HttpGet("DeleteProviderById/{id}")]
        public void DeleteProviderById(Guid id)
        {
        }

        [HttpGet("DeleteProviderByName/{firstName}/{lastName}")]
        public void DeleteProviderById(string firstName, string lastName)
        {
        }

        [HttpGet("DeleteProviderByName/{firstName}/{lastName}")]
        public void DeleteProviderByName(string firstName, string lastName)
        {
        }

        [HttpGet("UpdateProviderById/{id}/{firstName}/{lastName}/{displayName}")]
        public void UpdateProviderById(Guid id, string firstName, string lastName, string displayName)
        {
        }

        [HttpGet("UpdateProviderByName/{currentFirstName}/{currentLastName}/{newFirstName}/{newLastName}/{newDisplayName}")]
        public void UpdateProviderByName(string currentFirstName, string currentLastName, string newFirstName, string newDisplayName)
        {
        }
    }
}