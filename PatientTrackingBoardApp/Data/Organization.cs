using System;
using System.Collections.Generic;

#nullable disable

namespace PatientTrackingBoardApp.Data
{
    public partial class Organization
    {
        public Organization()
        {
            Accounts = new HashSet<Account>();
            Locations = new HashSet<Location>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
    }
}
