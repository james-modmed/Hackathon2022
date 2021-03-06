using PatientTrackingBoardApp.Data;
using PatientTrackingBoardApp.Data.Tracking;
using System;
using System.Linq;

namespace PatientTrackingBoardApp.Services.VisitStatus
{
    public class VisitStatusService
    {
        private readonly PatientTrackingBoardDBContext _dbContext;

        public VisitStatusService(PatientTrackingBoardDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Data.VisitCode GetVisitCodeFromName(string name)
        {
            return _dbContext.VisitCodes.Where(c => c.Name == name).FirstOrDefault();
        }

        public Visit GetVisitFromPatientSourceIdAndVisitDate(string patientSourceId, DateTime visitDate)
        {
            return _dbContext.Visits.Where(v => v.Patient.SourceId == patientSourceId && v.VisitDate == visitDate).FirstOrDefault();
        }

        public VisitStatusModel InsertVisitStatus(VisitStatusModel model)
        {
            var entityModel = new Data.VisitStatus
            {
                Id = model.Id,
                VisitId = model.VisitId,
                VisitCodeId = model.VisitCodeId,
                DateModified = model.DateModified
            };
            _dbContext.VisitStatuses.Add(entityModel);
            _dbContext.SaveChanges();
            model.DateCreated = entityModel.DateCreated;
            return model;
        }
    }
}