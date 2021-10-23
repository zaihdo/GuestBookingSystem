using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_30.Business
{
    public class Booking
    {
        #region data members
        private int bookingID;
        private string guestID;
        private int numRooms;
        private DateTime checkIn;
        private DateTime checkOut;
        private int totalCharge;
        private bool depositPaid;
        #endregion

        #region constructor
        public Booking()
        {
            bookingID = 1;
            checkIn = DateTime.MinValue;
            checkOut = DateTime.MinValue;
            numRooms = 0;
            totalCharge = 0;
            depositPaid = false;
        }

        public Booking(string bookingNum, DateTime checkInDate, DateTime checkOutDate, int numOfRooms, int total, bool deposit )
        {
            bookingID = bookingNum;
            checkIn = checkInDate;
            checkOut = checkOutDate;
            numRooms = numOfRooms;
            totalCharge = total;
            depositPaid = deposit;
        }
        #endregion

        #region properties
        public string getGuestID
        {
            get { return guestID; }
            set { guestID = value; }
        }
        public string getBookingID
        {
            get { return bookingID;  }
            set { bookingID = value; }
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
