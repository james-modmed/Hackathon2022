using System;
using System.Collections.Generic;
using System.Linq;
using PatientTrackingBoardApp.Data;
using PatientTrackingBoardApp.Data.Tracking;

namespace PatientTrackingBoardApp.Services.Board
{
    public class BoardService
    {
        private readonly PatientTrackingBoardDBContext _dbContext;

        public BoardService(PatientTrackingBoardDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<VisitModel> GetVisits(Guid locationId)
        {
            return _dbContext.Visits.Select(p => new VisitModel
            {
                Patient = new PatientModel
                {
                    FirstName = p.Patient.FirstName,
                    LastName = p.Patient.LastName
                },
                CurrentPhysician = new ProviderModel
                {
                    FirstName = p.Provider.FirstName,
                    LastName = p.Provider.LastName,
                    DisplayName = p.Provider.DisplayName
                },
                VisitDate = p.VisitDate,
                VisitName = p.Id.ToString(),
                VisitStatus = "", //todo: Ask robert where our visit status is
                LastStatus = p.DateModified
            }).ToList();
        }
    }
}
