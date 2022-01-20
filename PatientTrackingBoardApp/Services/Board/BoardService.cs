using System.Collections.Generic;
using System.Linq;
using PatientTrackingBoardApp.Data;
using Patient = PatientTrackingBoardApp.Data.Tracking.Patient;
using Provider = PatientTrackingBoardApp.Data.Tracking.Provider;
using Visit = PatientTrackingBoardApp.Data.Tracking.Visit;

namespace PatientTrackingBoardApp.Services.Board
{
    public class BoardService
    {
        private readonly PatientTrackingBoardDBContext _dbContext;

        public BoardService(PatientTrackingBoardDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Visit> GetVisits(string locationId)
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
                VisitName = p.Id.ToString(),
                VisitStatus = p.VisitStatuses.FirstOrDefault(j => j.Id == p.VisitStatusId).VisitCode.Name,
                LastStatus = p.DateModified
            }).ToList();
        }
    }
}
