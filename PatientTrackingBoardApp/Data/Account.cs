using System;
using System.Collections.Generic;

#nullable disable

namespace PatientTrackingBoardApp.Data
{
    public partial class Account
    {
        public Guid Id { get; set; }
        public Guid OrganizationId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool? IsActive { get; set; }

        public virtual Organization Organization { get; set; }
    }
}
