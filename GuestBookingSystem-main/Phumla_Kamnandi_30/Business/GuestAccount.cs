using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_30.Business
{
    class GuestAccount
    {

        #region Data members
        private string guestAccNum;
        private int totalCharges;
        #endregion

        #region Property Methods

        public string getGuestAccNum
        {
            get { return getGuestAccNum; }
            set { guestAccNum = value; }
        }

        public int getTotalCharges
        {
            get { return totalCharges; }
            set { totalCharges = value; }
        }
        #endregion

        #region Constructor

        public GuestAccount(string guestID, int charges)
        {
            guestAccNum = guestID;
            totalCharges = charges;
        }

        public GuestAccount()
        {
            guestAccNum = "";
            totalCharges = 0 ;
        }
        #endregion
    }
}
