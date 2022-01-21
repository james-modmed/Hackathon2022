using System;

namespace PatientTrackingBoardApp.Data.Tracking
{
    public class VisitCodeModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ColorCode { get; set; }
        public int SortOrder { get; set; }
    }
}
