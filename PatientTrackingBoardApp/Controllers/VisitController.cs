using Microsoft.AspNetCore.Mvc;
using PatientTrackingBoardApp.Services.Board;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PatientTrackingBoardApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitController : ControllerBase
    {
        private readonly BoardService _boardService;

        public VisitController(BoardService boardService)
        {
            _boardService = boardService;
        }

        [HttpPost("AddVisitByPatientId/{patientId}/{providerId}/{visitDate}")]
        public void AddVisitByPatientId(string patientId, string providerId, string visitDate)
        {
        }

        [HttpPost("AddVisitByPatientSourceId/{patientSourceId}/{providerId}/{visitDate}")]
        public void AddVisitByPatientSourceId(string patientSourceId, string providerId, string visitDate)
        {
        }

        [HttpPost("DeleteVisitByVisitId/{patientId}/{providerId}/{visitDate}")]
        public void DeleteVisitByVisitId(string patientId, string providerId, string visitDate)
        {
        }
    }
}