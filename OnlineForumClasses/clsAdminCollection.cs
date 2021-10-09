using System.Collections.Generic;
using System;

namespace OnlineForumClasses
{
    public class clsAdminCollection
    {
        private List<clsAdmin> mAdminList = new List<clsAdmin>();
        clsAdmin mThisAdmin = new clsAdmin();
        public List<clsAdmin> AdminList
        {
            get
            {
                return mAdminList;
            }

            set
            {
                mAdminList = value;
            }
        }


        // Public property for count
        public int Count
        {
            get
            {
                // Return the count list
                return mAdminList.Count;
            }
            set
            {
                //later
            }
        }


        public clsAdmin ThisAdmin
        {
            get
            {
                // Return the private data
                return mThisAdmin;
            }

            set
            {
                mThisAdmin = value;
            }
        }

        public clsAdminCollection()
        {
            // Var for the index
            Int32 Index = 0;
            // Var to store the rcord count
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            // Exeucte the stored procudure
            DB.Execute("sproc_tblAdmin_SelectAll");
            // Get the count of the records
            RecordCount = DB.Count;
            // While records to process
            while (Index < RecordCount)
            {
                clsAdmin AnAdmin = new clsAdmin();
                AnAdmin.AdminId = Convert.ToInt32(DB.DataTable.Rows[Index]["AdminId"]);
                AnAdmin.AdminFirstName = Convert.ToString(DB.DataTable.Rows[Index]["AdminFirstName"]);
                AnAdmin.AdminLastName = Convert.ToString(DB.DataTable.Rows[Index]["AdminLastName"]);
                AnAdmin.AdminTelephone = Convert.ToString(DB.DataTable.Rows[Index]["AdminTelephone"]);
                AnAdmin.AdminEmail = Convert.ToString(DB.DataTable.Rows[Index]["AdminEmail"]);
                AnAdmin.AdminPassword = Convert.ToString(DB.DataTable.Rows[Index]["AdminPassword"]);
                // Add the reocrd to the private data
                mAdminList.Add(AnAdmin);
                // Point at the nect record
                Index++;

            }
        }



        public int Add()
        {
            // Adds a  new reocrd to the databse
            // Connect to the database
            clsDataConnection DB = new clsDataConnection();
            // Set the stroed procudure
            // DB.AddParameter("AdminId", mThisAdmin.AdminId);
            DB.AddParameter("AdminFirstName", ThisAdmin.AdminFirstName);
            DB.AddParameter("AdminLastName", ThisAdmin.AdminLastName);
            DB.AddParameter("AdminTelephone", ThisAdmin.AdminTelephone);
            DB.AddParameter("AdminEmail", ThisAdmin.AdminEmail);
            DB.AddParameter("AdminPassword", ThisAdmin.AdminPassword);
            // Execute the qeury
            return DB.Execute("sproc_tblAdmin_Insert");
        }

        public void Delete()
        {
            // Deleted the record pointed to by ThisAdmin
            // Connect to the database
            clsDataConnection DB = new clsDataConnection();
            // Set the paramerers for the stored rocudure
            DB.AddParameter("@AdminId", mThisAdmin.AdminId);
            // Execute the stored procudure
            DB.Execute("sproc_tblAdmin_Delete");


        }

        public void Update()
        {
            // Adds a  new record to the databse
            // Connect to the database
            clsDataConnection DB = new clsDataConnection();
            // Set the stroed procudure
            DB.AddParameter("AdminId", mThisAdmin.AdminId);
            DB.AddParameter("AdminFirstName", ThisAdmin.AdminFirstName);
            DB.AddParameter("AdminLastName", ThisAdmin.AdminLastName);
            DB.AddParameter("AdminTelephone", ThisAdmin.AdminTelephone);
            DB.AddParameter("AdminEmail", ThisAdmin.AdminEmail);
            DB.AddParameter("AdminPassword", ThisAdmin.AdminPassword);
            // Execute the qeury
            DB.Execute("sproc_tblAdmin_Update");
        }

        public void ReportByAdminLastName(string AdminLastName)
        {
            // Filters the record based on a full or partial lastname
            // Connect to database
            clsDataConnection DB = new clsDataConnection();
            // Send the name parameter to the database
            DB.AddParameter("@AdminLastName", AdminLastName);
            // Execute the styored procudure 
            DB.Execute("sproc_tblAdmin_FilterByAdminLastName");
            // Popoulate the array list with the table
            PopulateArray(DB);
        }


        void PopulateArray(clsDataConnection DB)
        {
            // VAR FOR THE INDEX
            Int32 Index = 0;
            // Var to store the record count
            Int32 RecordCount = 0;
            // Object for data connection
            // Get the count of records
            RecordCount = DB.Count;
            // Clear the private array list
            mAdminList = new List<clsAdmin>();
            // While there are records to process
            while (Index < RecordCount)
            {
                // Create a blank Admin
                clsAdmin AnAdmin = new clsAdmin();
                // Read in fields form the current record
                AnAdmin.AdminId = Convert.ToInt32(DB.DataTable.Rows[Index]["AdminId"]);
                AnAdmin.AdminFirstName = Convert.ToString(DB.DataTable.Rows[Index]["AdminFirstName"]);
                AnAdmin.AdminLastName = Convert.ToString(DB.DataTable.Rows[Index]["AdminLastName"]);
                AnAdmin.AdminTelephone = Convert.ToString(DB.DataTable.Rows[Index]["AdminTelephone"]);
                AnAdmin.AdminEmail = Convert.ToString(DB.DataTable.Rows[Index]["AdminEmail"]);
                AnAdmin.AdminPassword = Convert.ToString(DB.DataTable.Rows[Index]["AdminPassword"]);
                // Add the record to the private data memeber
                mAdminList.Add(AnAdmin);
                // POINT AT the next index
                Index++;
            }
        }




    }
}