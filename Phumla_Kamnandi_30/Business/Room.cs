using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_30.Business
{
    class Room
    {
        #region data members
        private int roomNum;
        private int rate;
        private bool occupancyStatus;
        #endregion

        #region constructor
        public Room()
        {
            roomNum = 0;
            rate = 0;
            occupancyStatus = false;
        }

        public Room(int roomNumber, int roomRate, bool occupancy)
        {
            roomNum = roomNumber;
            rate = roomRate;
            occupancyStatus = occupancy;
        }
        #endregion

        #region properties
        public int getRoomNum
        {
            get { return roomNum;  }
            set { roomNum = value;  }
        }

        public int getRate
        {
            get { return rate; }
            set { rate = value; }
        }

        public bool getOccupanycStatus
        {
            get { return occupancyStatus; }
            set { occupancyStatus = value; }
        }
        #endregion
    }
}
