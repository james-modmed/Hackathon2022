using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientTrackingBoardApp.Services.Layout
{
    public class ViewOptionService
    {
        private bool _navBarVisible = true;
        public Action OnChanged{ get; set; }

        public void NavBarVisible(bool visible)
        {
            _navBarVisible = visible;
            if (OnChanged != null)
                OnChanged();
        }

        public string NavBarClass
        {
            get
            {
                return _navBarVisible? String.Empty:"d-none";
            }
        }
    }
}
