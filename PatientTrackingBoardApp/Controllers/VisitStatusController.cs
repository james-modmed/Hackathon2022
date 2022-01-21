using Microsoft.AspNetCore.Mvc;
using PatientTrackingBoardApp.Data.Tracking;
using PatientTrackingBoardApp.Services.VisitStatus;

namespace PatientTrackingBoardApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitStatusController : ControllerBase
    {
        private readonly VisitStatusService _visitService;

        public VisitStatusController(VisitStatusService visitService)
        {
            _visitService = visitService;
        }

        [HttpPost]
        public ActionResult<VisitStatusModel> Insert(VisitStatusModel model)
        {
            return Ok(_visitService.InsertVisitStatus(model));
        }
    }
}
