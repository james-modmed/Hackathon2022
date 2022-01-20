using PatientTrackingBoardApp.Data.Tracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientTrackingBoardApp.Services.Board
{
    public class BoardService
    {
        public List<Visit> GetVisits(string locationId)
        {
            return new List<Visit>
            {
                new Visit{ Patient = new Patient{ FirstName ="John", LastName = "Doe"}, CurrentPhysician = new Provider{ DisplayName = "Dr John Smith MD"}, VisitName = "Consultation", VisitStatus="Arrived", LastStatus= new DateTime(2022, 01, 20, 14, 31, 00)   },
                new Visit{ Patient = new Patient{ FirstName ="Jane", LastName = "Jones"}, CurrentPhysician = new Provider{ DisplayName = "Dr Frank Adam MD"}, VisitName = "Colonoscopy", VisitStatus="PreOperative", LastStatus= new DateTime(2022, 01, 20, 16, 22, 00)  },
                new Visit{ Patient = new Patient{ FirstName ="Mary", LastName = "Sue"}, CurrentPhysician = new Provider{ DisplayName = "Dr John Smith MD"}, VisitName = "Consultation", VisitStatus="Arrived", LastStatus= new DateTime(2022, 01, 20, 12, 31, 00)  },
            };
        }
    }
}
