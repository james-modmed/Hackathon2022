﻿using PatientTrackingBoardApp.Data;
using PatientTrackingBoardApp.Data.Tracking;

namespace PatientTrackingBoardApp.Services.VisitStatus
{
    public class VisitStatusService
    {
        private readonly PatientTrackingBoardDBContext _dbContext;

        public VisitStatusService(PatientTrackingBoardDBContext dbContext)
        {
            _dbContext = dbContext;
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
