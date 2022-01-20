using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientTrackingBoardApp.Services.Location
{
    public class LocationService
    {
        private static List<PatientTrackingBoardApp.Data.Tracking.Location> Locs =  new List<Data.Tracking.Location>
            {
                new Data.Tracking.Location{
                        Id = Guid.NewGuid(),
                        Name = "Main Office"
                    },
                new Data.Tracking.Location{
                        Id = Guid.NewGuid(),
                        Name = "Ambulatory Surgical Center"
                    },
                new Data.Tracking.Location{
                        Id = Guid.NewGuid(),
                        Name = "Lab"
                    },
            };

        public List<PatientTrackingBoardApp.Data.Tracking.Location> GetLocations(Guid orgId)
        {
            return Locs;
        }

        public Data.Tracking.Location Read(Guid locationId)
        {
            return Locs.FirstOrDefault(l => l.Id == locationId);
        }
    }
}
