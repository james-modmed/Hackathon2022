using System;
using System.Collections.Generic;

#nullable disable

namespace PatientTrackingBoardApp.Data
{
    public partial class VisitCode
    {
        public VisitCode()
        {
            VisitStatuses = new HashSet<VisitStatus>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ColorCode { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int SortOrder { get; set; }

        public virtual ICollection<VisitStatus> VisitStatuses { get; set; }
    }
}
