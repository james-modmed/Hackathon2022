using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientTrackingBoardApp.Data.Tracking
{
    public class Visit
    {
        public Patient Patient { get; set;}
        public Provider CurrentPhysician {get; set; }

        public string VisitName {get; set; }

        public string VisitStatus {get; set;}

        public DateTime LastStatus {get;set;}
    }
}
