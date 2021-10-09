using System.Collections.Generic;
using System;

namespace OnlineForumClasses
{
    public class clsUserCollection
    {
        private List<clsUser> mUserList = new List<clsUser>();
        clsUser mThisUser = new clsUser();
        public List<clsUser> UserList
        {
            get
            {
                return mUserList;
            }

            set
            {
                mUserList = value;
            }
        }


        //public property for cout
        public int Count
        {
            get
            {
                //return the count list
                return mUserList.Count;
            }
            set
            {
                //later
            }
        }


        public clsUser ThisUser
        {
            get
            {
                //retturn the private data
                return mThisUser;
            }

            set
            {
                mThisUser = value;
            }
        }

        public clsUserCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the rcord count
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            //exeucte the stored procudure
            DB.Execute("sproc_tblUser_SelectAll");
            //get th oucnt of the records
            RecordCount = DB.Count;
            //while records to process
            while (Index < RecordCount)
            {
                clsUser AnUser = new clsUser();
                AnUser.UserId = Convert.ToInt32(DB.DataTable.Rows[Index]["UserId"]);
                AnUser.UserFirstName = Convert.ToString(DB.DataTable.Rows[Index]["UserFirstName"]);
                AnUser.UserLastName = Convert.ToString(DB.DataTable.Rows[Index]["UserLastName"]);
                AnUser.UserTelephone = Convert.ToString(DB.DataTable.Rows[Index]["UserTelephone"]);
                AnUser.UserEmail = Convert.ToString(DB.DataTable.Rows[Index]["UserEmail"]);
                AnUser.UserPassword = Convert.ToString(DB.DataTable.Rows[Index]["UserPassword"]);
                //add the reocrd to the private data
                mUserList.Add(AnUser);
                //point at the nect record
                Index++;

            }
        }



        public int Add()
        {
            //adds a  new reocrd to the databse
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the stroed procudure
            // DB.AddParameter("UserId", mThisUser.UserId);
            DB.AddParameter("UserFirstName", ThisUser.UserFirstName);
            DB.AddParameter("UserLastName", ThisUser.UserLastName);
            DB.AddParameter("UserTelephone", ThisUser.UserTelephone);
            DB.AddParameter("UserEmail", ThisUser.UserEmail);
            DB.AddParameter("UserPassword", ThisUser.UserPassword);
            //execute the qeury
            return DB.Execute("sproc_tblUser_Insert");
        }

        public void Delete()
        {
            //deleted the record pointed to by ThisUser
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paramerers for the stored rocudure
            DB.AddParameter("@UserId", mThisUser.UserId);
            //execute the stored procudure
            DB.Execute("sproc_tblUser_Delete");


        }

        public void Update()
        {
            //adds a  new reocrd to the databse
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the stroed procudure
            DB.AddParameter("UserId", mThisUser.UserId);
            DB.AddParameter("UserFirstName", ThisUser.UserFirstName);
            DB.AddParameter("UserLastName", ThisUser.UserLastName);
            DB.AddParameter("UserTelephone", ThisUser.UserTelephone);
            DB.AddParameter("UserEmail", ThisUser.UserEmail);
            DB.AddParameter("UserPassword", ThisUser.UserPassword);
            //execute the qeury
            DB.Execute("sproc_tblUser_Update");
        }

        public void ReportByUserEmail(string UserEmail)
        {
            //filters the record based on a full or partial fisrtname
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //send the name parameter to the database
            DB.AddParameter("@UserEmail", UserEmail);
            //execute the styored procudure 
            DB.Execute("sproc_tblUser_FilterByUserEmail");
            //popoulate the array list with the table
            PopulateArray(DB);
        }


        void PopulateArray(clsDataConnection DB)
        {
            //VAR FOR THE INDEX
            Int32 Index = 0;
            //var to store the rrdeord count
            Int32 RecordCount = 0;
            //object for data connection
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mUserList = new List<clsUser>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //cretae a blank User
                clsUser AnUser = new clsUser();
                //read in fields form the current record
                AnUser.UserId = Convert.ToInt32(DB.DataTable.Rows[Index]["UserId"]);
                AnUser.UserFirstName = Convert.ToString(DB.DataTable.Rows[Index]["UserFirstName"]);
                AnUser.UserLastName = Convert.ToString(DB.DataTable.Rows[Index]["UserLastName"]);
                AnUser.UserTelephone = Convert.ToString(DB.DataTable.Rows[Index]["UserTelephone"]);
                AnUser.UserEmail = Convert.ToString(DB.DataTable.Rows[Index]["UserEmail"]);
                AnUser.UserPassword = Convert.ToString(DB.DataTable.Rows[Index]["UserPassword"]);
                //add the record to the private data memeber
                mUserList.Add(AnUser);
                //POINT AT the next index
                Index++;
            }
        }


    }
}