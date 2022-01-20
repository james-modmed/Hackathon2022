using System;

namespace PatientTrackingBoardApp.Data.Tracking
{
    public class VisitModel
    {
        public PatientModel Patient { get; set;}
        public ProviderModel CurrentPhysician {get; set; }

        public string VisitName {get; set; }

        public string VisitStatus {get; set;}
        public DateTime VisitDate { get; set; }

        public DateTime LastStatus {get;set;}
    }
}
