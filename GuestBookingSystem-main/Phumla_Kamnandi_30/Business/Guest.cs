using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_30.Business
{
    class Guest:Person
    {
        #region Data Members
        private string guestID;
       
        #endregion

        #region properties
        public string getGuestID
        {
            get { return guestID;  }
            set { guestID = value; }
        }
        #endregion

        #region Constructor
        public Guest(string guestId) 
        {
            guestID = guestId;            
        }
        #endregion

    }
}
