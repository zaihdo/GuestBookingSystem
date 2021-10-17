using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_30.Business_layer
{
    class Booking
    {
        #region data members
        private string bookingID;
        private int numRooms;
        private DateTime checkIn;
        private DateTime checkOut;
        private int totalCharge;
        private bool depositPaid;
        #endregion

        #region properties
        public string getBookingID
        {
            get { return bookingID;  }
        }

        public int getNumRooms
        {
            get { return numRooms;  }
            set { numRooms = value; }
        }

        public DateTime getCheckIn
        {
            get { return checkIn ;  }
            set { checkIn = value;  }
        }

        public DateTime getCheckOut
        {
            get { return checkOut; }
            set { checkOut = value; }
        }

        public int getTotalCharge
        {
            get { return totalCharge; }
            set { totalCharge = value; }
        }

        public bool getDepositPaid
        {
            get { return depositPaid; }
            set { depositPaid = value; }
        }
        #endregion
    }
}
