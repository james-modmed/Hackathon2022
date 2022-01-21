using Microsoft.AspNetCore.Mvc;
using PatientTrackingBoardApp.Data.Tracking;
using PatientTrackingBoardApp.Services.VisitStatus;
using System;

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

        [HttpGet("UpdateVisitCode/{patientSourceId}/{visitDate}/{visitCodeName}")]
        public void UpdateVisitCode(string patientSourceId, DateTime visitDate, string visitCodeName)
        {
            var visit = _visitService.GetVisitFromPatientSourceIdAndVisitDate(patientSourceId, visitDate);
            var visitCode = _visitService.GetVisitCodeFromName(visitCodeName);
            if (visit != null && visitCode != null)
            {
                var visitStatusModel = new VisitStatusModel()
                {
                    Id = Guid.NewGuid(),
                    VisitId = visit.Id,
                    VisitCodeId = visitCode.Id,
                    DateCreated = (DateTime.Now).AddDays(1),
                    DateModified = (DateTime.Now).AddDays(1)
                };

                Insert(visitStatusModel);
            }
        }
    }
}