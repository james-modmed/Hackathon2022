using System;
using System.Collections.Generic;

#nullable disable

namespace PatientTrackingBoardApp.Data
{
    public partial class Provider
    {
        public Provider()
        {
            Visits = new HashSet<Visit>();
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public virtual ICollection<Visit> Visits { get; set; }
    }
}
