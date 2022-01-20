using System;
using System.Collections.Generic;
using System.Linq;
using PatientTrackingBoardApp.Data;
using PatientTrackingBoardApp.Data.Tracking;

namespace PatientTrackingBoardApp.Services.Location
{
    public class LocationService
    {
        private readonly PatientTrackingBoardDBContext _dbContext;

        public LocationService(PatientTrackingBoardDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<LocationModel> GetLocations(Guid orgId)
        {
            return _dbContext.Locations.Where(p => p.OrganizationId == orgId).Select(p => new LocationModel
            {
                Name = p.Name,
                Id = p.Id
            }).ToList();
        }

        public LocationModel Read(Guid locationId)
        {
            return _dbContext.Locations.Where(p => p.Id == locationId).Select(p => new LocationModel
            {
                Name = p.Name,
                Id = p.Id
            }).FirstOrDefault();
        }
    }
}
