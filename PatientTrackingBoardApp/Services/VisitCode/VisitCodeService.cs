using System.Collections.Generic;
using System.Linq;
using PatientTrackingBoardApp.Data;
using PatientTrackingBoardApp.Data.Tracking;

namespace PatientTrackingBoardApp.Services.VisitCode
{
    public class VisitCodeService
    {
        private readonly PatientTrackingBoardDBContext _dbContext;

        public VisitCodeService(PatientTrackingBoardDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<VisitCodeModel> GetVisitCodes()
        {
            return _dbContext.VisitCodes
                .OrderBy(p => p.SortOrder)
                .Select(p => new VisitCodeModel
                {
                    Id = p.Id,
                    ColorCode = p.ColorCode,
                    Name = p.Name,
                    SortOrder = p.SortOrder
                }).ToList();
        }
    }
}
