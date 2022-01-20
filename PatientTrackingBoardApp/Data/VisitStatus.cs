using System;
using System.Collections.Generic;

#nullable disable

namespace PatientTrackingBoardApp.Data
{
    public partial class VisitStatus
    {
        public Guid Id { get; set; }
        public Guid VisitId { get; set; }
        public Guid VisitCodeId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public virtual Visit Visit { get; set; }
        public virtual VisitCode VisitCode { get; set; }
    }
}
