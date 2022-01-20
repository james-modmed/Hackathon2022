using System;
using System.Collections.Generic;

#nullable disable

namespace PatientTrackingBoardApp.Data
{
    public partial class GetVisitStatus
    {
        public string Patient { get; set; }
        public string Provider { get; set; }
        public string Procedure { get; set; }
        public string Status { get; set; }
    }
}
