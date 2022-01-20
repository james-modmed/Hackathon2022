using System;
using System.Collections.Generic;

#nullable disable

namespace PatientTrackingBoardApp.Data
{
    public partial class Visit
    {
        public Visit()
        {
            VisitStatuses = new HashSet<VisitStatus>();
        }

        public Guid Id { get; set; }
        public Guid PatientId { get; set; }
        public Guid ProviderId { get; set; }
        public string Procedure { get; set; }
        public DateTime VisitDate { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public virtual Patient Patient { get; set; }
        public virtual Provider Provider { get; set; }
        public virtual ICollection<VisitStatus> VisitStatuses { get; set; }
    }
}
