using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phumla_Kamnandi_30.Business;

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
            Add2Collection()
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

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)//zaidh stopped here
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    aGuest = new Guest();
                    aGuest.getGuestID = Convert.ToString(myRow["GuestID"]).TrimEnd();
                    aGuest.Name = Convert.ToString(myRow["Name"]).TrimEnd(); 
                    aGuest.Address = Convert.ToString(myRow["Address"]).TrimEnd();
                    aGuest.Telephone = Convert.ToString(myRow["Phone"]).TrimEnd();
                    aGuest.ID = Convert.ToString(myRow["ID"]).TrimEnd();
                    guests.Add(aGuest);
                }
            }
        }

        private void FillRow(DataRow aRow, Guest aGuest, DB.DBOperation operation)
        {
            Guest guest
                if (operation == DB.DBOperation.Add)
            {
                aRow["GuestID"] = aGuest.getGuestID;
                aRow["ID"] = aGuest.ID; //not too sure if this must be inside the if statement
            }
            aRow["Name"] = aGuest.Name;
            aRow["Phone"] = aGuest.Telephone;
            aRow["Address"] = aGuest.Address;

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
                    FillRow(aRow, anEmp, operation);
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    //Add to the dataset
                    break;
                case DB.DBOperation.Edit:
                    // For the Edit section you have to find a row instead of creating a new row.
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(anEmp, dataTable)];
                    //Fill this row for the Edit operation by calling the FillRow method
                    FillRow(aRow, anEmp, operation);
                    break;
                case DB.DBOperation.Delete:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(anEmp, dataTable)];
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

        private void Build_UPDATE_Parameters(Employee anEmp)
        {
            //---Create Parameters to communicate with SQL UPDATE
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@Name", SqlDbType.NVarChar, 100, "Name");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            //Do for all fields other than ID and EMPID as for Insert 
            param = new SqlParameter("@Phone", SqlDbType.NVarChar, 15, "Phone");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Role", SqlDbType.TinyInt, 1, "Role");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            //testing the ID of record that needs to change with the original ID of the record
            param = new SqlParameter("@Original_ID", SqlDbType.NVarChar, 15, "ID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
        }

    }
}
