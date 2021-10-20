using Phumla_Kamnandi_30.Business_layer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_30.Data
{
    public class BookingDB : DB
    {
        #region  Data members       
        private string table = "Bookings";
        private string sqlLocal = "SELECT * FROM Bookings";
        private Collection<Booking> bookings;

        #endregion

        #region Property Method: Collection
        public Collection<Booking> AllBookings
        {
            get
            {
                return bookings;
            }
        }
        #endregion

        #region Constructor
        public BookingDB() : base()
        {
            bookings = new Collection<Booking>();
            FillDataSet(sqlLocal, table);
            Add2Collection(table);
            
        }
        #endregion

        #region Utility Methods
        public DataSet GetDataSet()
        {
            return dsMain;
        }
        private void Add2Collection(string table)
        {
            DataRow myRow = null;
            Booking aBooking;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)//zaidh stopped here
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    aBooking = new Booking();
                    aBooking.getBookingID = Convert.ToString(myRow["BookingID"]).TrimEnd();
                    aBooking.getGuestID = Convert.ToString(myRow["GuestID"]).TrimEnd();
                    aBooking.getNumRooms = Convert.ToInt32(myRow["NoOfRooms"]);
                    aBooking.getCheckIn = Convert.ToDateTime(myRow["CheckInDate"]);
                    aBooking.getCheckOut = Convert.ToDateTime(myRow["CheckOutDate"]);
                    aBooking.getTotalCharge = Convert.ToInt32(myRow["TotalCharge"]);
                    aBooking.getDepositPaid = Convert.ToBoolean(myRow["DepositPaid"]);
                }
            }
        }
        private void FillRow(DataRow aRow, Booking aBooking, DB.DBOperation operation)
        {
            if (operation == DB.DBOperation.Add)
            {
                aRow["BookingID"] = aBooking.getBookingID;  //NOTE square brackets to indicate index of collections of fields in row.
                //aRow["BookingID"] = aBooking.ID;
            }
            aRow["GuestID"] = aBooking.getGuestID;
            aRow["NoOfRooms"] = aBooking.getNumRooms;
            aRow["CheckInDate"] = aBooking.getCheckIn;
            aRow["CheckOutDate"] = aBooking.getCheckOut;
            aRow["TotalCharge"] = aBooking.getTotalCharge;
            aRow["DepositPaid"] = aBooking.getDepositPaid;//*** For each role add the specific data variables
        }

        private int FindRow(Booking aBooking, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                //Ignore rows marked as deleted in dataset
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //In c# there is no item property (but we use the 2-dim array) it is automatically known to the compiler when used as below
                    if (aBooking.getBookingID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["BookingID"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex += 1;
            }
            return returnValue;
        }
        #endregion


        #region Database Operations CRUD
        public void DataSetChange(Booking aBooking, DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table;

            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, aBooking, operation);
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    //Add to the dataset
                    break;
                case DB.DBOperation.Edit:
                    // For the Edit section you have to find a row instead of creating a new row.
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(aBooking, dataTable)];
                    //Fill this row for the Edit operation by calling the FillRow method
                    FillRow(aRow, aBooking, operation);
                    break;
                case DB.DBOperation.Delete:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(aBooking, dataTable)];
                    aRow.Delete();
                    break;
            }
        }
        #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Booking aBooking)
        {
            //Create Parameters to communicate with SQL INSERT...add the input parameter and set its properties.
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@BookingID", SqlDbType.NVarChar, 15, "BookingID");
            daMain.InsertCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.

            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 15, "BookingID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckInDate", SqlDbType.DateTime, 10, "CheckInDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckOutDate", SqlDbType.DateTime, 10, "CheckOutDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@NoOfRooms", SqlDbType.SmallInt, 10, "NoOfRooms");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@TotalCharge", SqlDbType.NVarChar, 15, "TotalCharge");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@DepositPaid", SqlDbType.VarChar, 3, "DepositPaid");
            daMain.InsertCommand.Parameters.Add(param);
            
            //***https://msdn.microsoft.com/en-za/library/ms179882.aspx
        }

        private void Build_UPDATE_Parameters(Booking aBooking)
        {
            //---Create Parameters to communicate with SQL UPDATE
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("BookingID", SqlDbType.NVarChar, 15, "BookingID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            //Do for all fields other than ID and EMPID as for Insert 
            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 15, "GuestID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckInDate", SqlDbType.DateTime, 10, "CheckInDate");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckOutDate", SqlDbType.DateTime, 10, "CheckOutDate");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@NoOfRooms", SqlDbType.NVarChar, 10, "NoOfRooms");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@TotalCharge", SqlDbType.NVarChar, 15, "TotalCharge");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@DepositPaid", SqlDbType.VarChar, 3, "DepositPaid");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Build_DELETE_Parameters()
        {
            //--Create Parameters to communicate with SQL DELETE
            SqlParameter param;
            param = new SqlParameter("@BookingID", SqlDbType.NVarChar, 15, "BookingID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.DeleteCommand.Parameters.Add(param);
        }

        private void Create_INSERT_Command(Booking aBooking)
        {
            //Create the command that must be used to insert values into the Books table..
            daMain.InsertCommand = new SqlCommand("INSERT into Booking (BookingID, GuestID, CheckInDate, CheckOutDate, NoOfRooms, TotalCharge, DepositPaid) VALUES (@BookingID, @GuestID, @CheckInDate, @CheckOutDate, @TotalCharge, @DepositPaid)", cnMain);

            Build_INSERT_Parameters(aBooking);
        }

        private void Create_UPDATE_Command(Booking aBooking)
        {
            //Create the command that must be used to insert values into one of the three tables
            //Assumption is that the ID and EMPID cannot be changed
            daMain.UpdateCommand = new SqlCommand("UPDATE Booking SET BookingID =@BookingID, GuestID =@GuestID, CheckInDate =@CheckInDate, CheckOutDate = @CheckOutDate" + "WHERE BookingID = @BookingID", cnMain);

            Build_UPDATE_Parameters(aBooking);
        }

        private string Create_DELETE_Command(Booking aBooking)
        {
            string errorString = null;
            daMain.DeleteCommand = new SqlCommand("DELETE FROM Booking WHERE BookingID = @BookingID", cnMain);
            //Create the command that must be used to delete values from the the appropriate table
            try
            {
                Build_DELETE_Parameters();
            }
            catch (Exception errObj)
            {
                errorString = errObj.Message + "  " + errObj.StackTrace;
            }
            return errorString;
        }

        public bool UpdateDataSource(Booking aBooking)
        {
            bool success = true;
            Create_INSERT_Command(aBooking);
            Create_UPDATE_Command(aBooking);
            Create_DELETE_Command(aBooking);
            
            success = UpdateDataSource(sqlLocal, table);
            return success;
        }
        #endregion

    }
}
