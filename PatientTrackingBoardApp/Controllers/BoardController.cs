using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using PatientTrackingBoardApp.Data.Tracking;
using PatientTrackingBoardApp.Services.Board;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PatientTrackingBoardApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardController : ControllerBase
    {
        private readonly BoardService _boardService;

        public BoardController(BoardService boardService)
        {
            _boardService = boardService;
        }

        [HttpGet("InternalBoard")]
        public IEnumerable<VisitModel> GetInternalBoard(Guid locationId)
        {
            return _boardService.GetVisits(locationId);
        }

        [HttpGet("ExternalBoard")]
        public IEnumerable<VisitModel> GetExternalBoard(Guid locationId)
        {
            return _boardService.GetVisits(locationId);
        }
    }
}
