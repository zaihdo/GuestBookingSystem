using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phumla_Kamnandi_30.Business;
using Phumla_Kamnandi_30.Business_layer;
using System.Collections.ObjectModel;

namespace Phumla_Kamnandi_30.Data
{
    class GuestDB:DB
    {

        #region  Data members        
        private string table1 = "Guest";
        private string sqlLocal1 = "SELECT * FROM Guest";
        private Collection<Guest> guests;

        #endregion  

        #region Property Method: Collection
        public Collection<Guest> AllGuests
        {
            get
            {
                return guests;
            }
        }
        #endregion

        #region constructor
        public GuestDB() : base()
        {
            guests = new Collection<Guest>();
            FillDataSet(sqlLocal1, table1);
            //Add2Collection();
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
            Guest aGuest;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    aGuest = new Guest();
                    aGuest.getGuestID = Convert.ToString(myRow["GuestID"]).TrimEnd();
                    aGuest.getID = Convert.ToString(myRow["ID"]).TrimEnd();
                    aGuest.getName = Convert.ToString(myRow["Name"]).TrimEnd(); 
                    aGuest.getAddress = Convert.ToString(myRow["Address"]).TrimEnd();
                    aGuest.getPhone = Convert.ToString(myRow["Phone"]).TrimEnd();
                    
                    guests.Add(aGuest);
                }
            }
        }

        private void FillRow(DataRow aRow, Guest aGuest, DB.DBOperation operation)
        {
            //Guest guest; for what purpose?
                if (operation == DB.DBOperation.Add)
            {
                aRow["GuestID"] = aGuest.getGuestID;
                aRow["ID"] = aGuest.getID; //not too sure if this must be inside the if statement
            }
            aRow["Name"] = aGuest.getName;
            aRow["Phone"] = aGuest.getPhone;
            aRow["Address"] = aGuest.getAddress;

        }

        private int FindRow(Guest aGuest, string table)
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
                    if (aGuest.getGuestID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["GuestID"])) //workshop used ID - i'm assuming we use GuestID??
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

        public void DataSetChange(Guest aGuest, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table1;
      
            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, aGuest, operation);
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    //Add to the dataset
                    break;
                case DB.DBOperation.Edit:
                    // For the Edit section you have to find a row instead of creating a new row.
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(aGuest, dataTable)];
                    //Fill this row for the Edit operation by calling the FillRow method
                    FillRow(aRow, aGuest, operation);
                    break;
                case DB.DBOperation.Delete:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(aGuest, dataTable)];
                    aRow.Delete();
                    break;
            }
        }
        #endregion

        #region Build Parameters, Create Commands & Update Database

        private void Build_INSERT_Parameters(Guest aGuest)
        {
            SqlParameter param = default(SqlParameter);
            //Create Parameters to communicate with SQL INSERT...add the input parameter and set its properties.
            param = new SqlParameter("@GuestID", SqlDbType.SmallInt, 4, "GuestID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@ID", SqlDbType.NVarChar, 15, "ID");
            daMain.InsertCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.

            //Do the same for Description & answer -ensure that you choose the right size
            param = new SqlParameter("@Name", SqlDbType.NVarChar, 100, "Name");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Phone", SqlDbType.NVarChar, 15, "Phone");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.NVarChar, 200, "Address");
            daMain.InsertCommand.Parameters.Add(param);
           
        }

        private void Build_UPDATE_Parameters(Guest aGuest)
        {
            //---Create Parameters to communicate with SQL UPDATE
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("GuestID", SqlDbType.TinyInt, 1, "GuestID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@ID", SqlDbType.NVarChar, 15, "ID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Name", SqlDbType.NVarChar, 100, "Name");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Phone", SqlDbType.NVarChar, 15, "Phone");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.NVarChar, 15, "Address");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

        }

        private void Build_DELETE_Parameters()
        {
            //--Create Parameters to communicate with SQL DELETE
            SqlParameter param;
            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 15, "GuestID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.DeleteCommand.Parameters.Add(param);
        }

        private void Create_INSERT_Command(Guest aGuest)
        {
            //Create the command that must be used to insert values into the Books table..
            daMain.InsertCommand = new SqlCommand("INSERT into Guest (GuestID, ID, Name, Phone, Address) VALUES (@GuestID, @ID, @Name, @Phone, @Address)", cnMain);

            Build_INSERT_Parameters(aGuest);
        }

        private void Create_UPDATE_Command(Guest aGuest)
        {
            //Create the command that must be used to insert values into one of the three tables
            //Assumption is that the ID and EMPID cannot be changed
            daMain.UpdateCommand = new SqlCommand("UPDATE Guest SET GuestID =@GuestID, ID =@ID, Name =@Name, Phone = @Phone, Address = @Address" + "WHERE GuestID = @GuestID", cnMain);

            Build_UPDATE_Parameters(aGuest);
        }

        private string Create_DELETE_Command(Guest aGuest)
        {
            string errorString = null;
            daMain.DeleteCommand = new SqlCommand("DELETE FROM Guest WHERE GuestID = @GuestID", cnMain);
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

        public bool UpdateDataSource(Guest aGuest)
        {
            bool success = true;
            Create_INSERT_Command(aGuest);
            Create_UPDATE_Command(aGuest);
            Create_DELETE_Command(aGuest);

            success = UpdateDataSource(sqlLocal1, table1);
            return success;
        }
        #endregion

    }
}
