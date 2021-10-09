using System;

namespace OnlineForumClasses
{
    public class clsUser
    {
        private Int32 mUserId;
        private string mUserFirstName;
        private string mUserLastName;
        private string mUserTelephone;
        private string mUserEmail;
        private string mUserPassword;
       


        public int UserId
        {
            get
            {
                return mUserId;
            }

            set
            {
                //set the value of the data private data meber
                mUserId = value;
            }

        }
        public string UserFirstName
        {
            get
            {
                return mUserFirstName;
            }
            set
            {
                mUserFirstName = value;
            }
        }
        public string UserLastName
        {
            get
            {
                return mUserLastName;
            }
            set
            {
                mUserLastName = value;
            }
        }

        public string UserTelephone
        {
            get
            {
                return mUserTelephone;
            }
            set
            {
                mUserTelephone = value;
            }
        }
        public string UserEmail
        {
            get
            {
                return mUserEmail;
            }
            set
            {
                mUserEmail = value;
            }
        }

        public string UserPassword
        {
            get
            {
                return mUserPassword;
            }
            set
            {
                mUserPassword = value;
            }
        }

        public bool Find(int UserId)
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paramerers for the stored rocudure
            DB.AddParameter("@UserId", UserId);
            //execute the stored procudure
            DB.Execute("sproc_tblUser_FilterByUserId");
            //if one record is found
            if (DB.Count == 1)
            {
                //set the private data member to the test data
                mUserId = Convert.ToInt32(DB.DataTable.Rows[0]["UserId"]);
                mUserFirstName = Convert.ToString(DB.DataTable.Rows[0]["UserFirstName"]);
                mUserLastName = Convert.ToString(DB.DataTable.Rows[0]["UserLastName"]);
                mUserTelephone = Convert.ToString(DB.DataTable.Rows[0]["UserTelephone"]);
                mUserEmail = Convert.ToString(DB.DataTable.Rows[0]["UserEmail"]);
                mUserPassword = Convert.ToString(DB.DataTable.Rows[0]["UserPassword"]);
                //always return true;
                return true;
            }
            //if no record is found
            else
            {
                //return false indicating a problem
                return false;
            }
        }



        public string Valid(string userFirstName, string userLastName, string userTelephone, string userEmail, string userPassword)
        {
            //string variable to store error message
            String Error = "";
            


            //if the name of the useris not blank
            if (userFirstName.Length < 2)
            {
                //return an error message
                Error = "the name may not be blank";
            }
            if (userFirstName.Length > 25)
            {
                //error
                Error = Error + "The user name cannot have more than 25 characters ";
            }
            if (userLastName.Length < 2)
            {
                //return an error message
                Error = "the name may not be blank";
            }
            if (userLastName.Length > 25)
            {
                //error
                Error = Error + "The user name cannot have more than 25 characters ";
            }
            if (userTelephone.Length == 0)
            {
                //return an error message
                Error = "the name may not be blank";
            }
            if (userTelephone.Length > 11)
            {
                //error
                Error = Error + "The user name cannot have more than 25 characters ";
            }


            if (userEmail.Length < 5)
            {
                //return an error message
                Error = "the email may not be less than 5 characters";
            }
            if (userEmail.Length > 50)
            {
                //error
                Error = Error + "The useremail cannot have more than 50 characters ";
            }

            if (userPassword.Length < 8)
            {
                //return an error message
                Error = "the Password may not be less than 8 be characters";
            }
            if (userPassword.Length > 50)
            {
                //error
                Error = Error + "The password cannot have more than 50 characters ";
            }
            //if the name of the useris not blank


            return Error;
        }

       
    }

}