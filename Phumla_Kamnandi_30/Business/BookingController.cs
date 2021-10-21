using Phumla_Kamnandi_30.Business_layer;
using Phumla_Kamnandi_30.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_30.Business
{
    public class BookingController
    {
        #region Data Members
        BookingDB BookingDB;
        Collection<Booking> bookings;
        #endregion

        #region Properties
        public Collection<Booking> Allbookings
        {
            get
            {
                return bookings;
            }
        }
        #endregion

        #region Constructor
        public BookingController()
        {
            //***instantiate the BookingDB object to communicate with the database
            BookingDB = new BookingDB();
            bookings = BookingDB.AllBookings;
        }
        #endregion

        #region Database Communication.
        public void DataMaintenance(Booking aBooking, DB.DBOperation operation)
        {
            int index = 0;
            //perform a given database operation to the dataset in meory; 
            BookingDB.DataSetChange(aBooking, operation);
            //perform operations on the collection
            switch (operation)
            {
                case DB.DBOperation.Add:
                    //*** Add the Booking to the Collection
                    bookings.Add(aBooking);
                    break;
                case DB.DBOperation.Edit:
                    index = FindIndex(aBooking);
                    bookings[index] = aBooking;  // replace Booking at this index with the updated Booking
                    break;
                case DB.DBOperation.Delete:
                    index = FindIndex(aBooking);  // find the index of the specific Booking in collection
                    bookings.RemoveAt(index);  // remove that Booking form the collection
                    break;

            }
        }

        //***Commit the changes to the database
        public bool FinalizeChanges(Booking booking)
        {
            //***call the BookingDB method that will commit the changes to the database
            return BookingDB.UpdateDataSource(booking);
        }
        #endregion

        #region Searching through a collection
        /*public Collection<Booking> FindByRole(Collection<Booking> bkngs, Role.RoleType roleVal)
        {
            Collection<Booking> matches = new Collection<Booking>();
            foreach (Booking bkng in bkngs)
            {
                if (bkng.role.getRoleValue == roleVal)
                {
                    matches.Add(bkng);
                }
            }
            return matches;
        }*/

        //This method receives a Booking ID as a parameter; finds the Booking object in the collection of bookings and then returns this object
        public Booking Find(string BookingID)
        {
            int index = 0;
            bool found = (bookings[index].getBookingID == BookingID);  //check if it is the first booking
            int count = bookings.Count;
            while (!(found) && (index < bookings.Count - 1))  //if not "this" student and you are not at the end of the list 
            {
                index = index + 1;
                found = (bookings[index].getBookingID == BookingID);   // this will be TRUE if found
            }
            return bookings[index];  // this is the one!  
        }

        public int FindIndex(Booking aBooking)
        {
            int counter = 0;
            bool found = false;
            found = (aBooking.getBookingID == bookings[counter].getBookingID);   //using a Boolean Expression to initialise found
            while (!(found) & counter < bookings.Count - 1)
            {
                counter += 1;
                found = (aBooking.getBookingID == bookings[counter].getBookingID);
            }
            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }
        }
        #endregion
    }
}
