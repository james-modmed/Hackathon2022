using System;

namespace PatientTrackingBoardApp.Data.Tracking
{
    public class VisitStatusModel
    {
        public Guid Id { get; set; }
        public Guid VisitId { get; set; }
        public Guid VisitCodeId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
