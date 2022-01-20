using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientTrackingBoardApp.Data.Tracking
{
    public class PatientModel
    {
        public string FirstName {get;set;}
        public string LastName {get;set;}


        public string MaskedName
        {
            get { return $"{FirstName[0].ToString().PadRight(FirstName.Length, '\u2022')} {LastName[0].ToString().PadRight(LastName.Length, '\u2022')}"; }
        }
    }
}
