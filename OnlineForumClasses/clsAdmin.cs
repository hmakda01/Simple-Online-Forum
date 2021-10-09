using System;

namespace OnlineForumClasses
{
    public class clsAdmin
    {
        private Int32 mAdminId;
        private string mAdminFirstName;
        private string mAdminLastName;
        private string mAdminTelephone;
        private string mAdminEmail;
        private string mAdminPassword;




        public int AdminId
        {
            get
            {
                return mAdminId;
            }

            set
            {
                // Set the value of the data private data meber
                mAdminId = value;
            }

        }
        public string AdminFirstName
        {
            get
            {
                return mAdminFirstName;
            }
            set
            {
                mAdminFirstName = value;
            }
        }
        public string AdminLastName
        {
            get
            {
                return mAdminLastName;
            }
            set
            {
                mAdminLastName = value;
            }
        }

        public string AdminTelephone
        {
            get
            {
                return mAdminTelephone;
            }
            set
            {
                mAdminTelephone = value;
            }
        }
        public string AdminEmail
        {
            get
            {
                return mAdminEmail;
            }
            set
            {
                mAdminEmail = value;
            }
        }

        public string AdminPassword
        {
            get
            {
                return mAdminPassword;
            }
            set
            {
                mAdminPassword = value;
            }
        }

        public bool Find(int AdminId)
        {
            // Connect to the database
            clsDataConnection DB = new clsDataConnection();
            // Set the paramerers for the stored procudure
            DB.AddParameter("@AdminId", AdminId);
            // Execute the stored procudure
            DB.Execute("sproc_tblAdmin_FilterByAdminId");
            // If one record is found
            if (DB.Count == 1)
            {
                // Set the private data member to the test data
                mAdminId = Convert.ToInt32(DB.DataTable.Rows[0]["AdminId"]);
                mAdminFirstName = Convert.ToString(DB.DataTable.Rows[0]["AdminFirstName"]);
                mAdminLastName = Convert.ToString(DB.DataTable.Rows[0]["AdminLastName"]);
                mAdminTelephone = Convert.ToString(DB.DataTable.Rows[0]["AdminTelephone"]);
                mAdminEmail = Convert.ToString(DB.DataTable.Rows[0]["AdminEmail"]);
                mAdminPassword = Convert.ToString(DB.DataTable.Rows[0]["AdminPassword"]);
                // Always return true;
                return true;
            }
            // If no record is found
            else
            {
                // Return false indicating a problem
                return false;
            }
        }



        public string Valid(string AdminFirstName, string AdminLastName, string AdminTelephone, string AdminEmail, string AdminPassword)
        {
            // String variable to store error message
            String Error = "";


            // If the name of the Admin is below 2 characters
            if (AdminFirstName.Length < 2)
            {
                // Return an error message
                Error = "the name may not be below 2 charcters";
            }
            if (AdminFirstName.Length > 25)
            {
                // Error
                Error = Error + "The Admin name cannot have more than 25 characters ";
            }
            if (AdminLastName.Length < 2)
            {
                // Return an error message
                Error = "the name may not be  below 2 charcters";
            }
            if (AdminLastName.Length > 25)
            {
                // Error
                Error = Error + "The Admin name cannot have more than 25 characters ";
            }
            if (AdminTelephone.Length == 0)
            {
                // Return an error message
                Error = "the telephone may not be blank";
            }
            if (AdminTelephone.Length > 11)
            {
                // Error
                Error = Error + "The  Telpehone number cannot have more than 11 characters ";
            }


            if (AdminEmail.Length < 5)
            {
                // Return an error message
                Error = "the email may not be blank";
            }
            if (AdminEmail.Length > 50)
            {
                // Error
                Error = Error + "The Admin Email cannot have more than 50 characters ";
            }

            if (AdminPassword.Length < 8)
            {
                // Return an error message
                Error = "the password has to be above 8";
            }
            if (AdminPassword.Length > 50)
            {
                // Error
                Error = Error + "The Admin Password cannot have more than 50 characters ";
            }


            return Error;
        }

        public string ValidAdmin(string AdminFirstName, string AdminLastName, string AdminTelephone, string AdminEmail, string AdminPassword)
        {
            //string variable to store error message
            String Error = "";


            //if the name of the Admin  not bellow 2 charcters
            if (AdminFirstName.Length < 2)
            {
                //return an error message
                Error = "the name must have more than 2 charcters";
            }
            if (AdminFirstName.Length > 25)
            {
                //error
                Error = Error + "The Admin name cannot have more than 25 characters ";
            }
            if (AdminLastName.Length < 2)
            {
                //return an error message
                Error = "the name must have more than 2 charcters";
            }
            if (AdminLastName.Length > 25)
            {
                //error
                Error = Error + "The Admin name cannot have more than 25 characters ";
            }
            if (AdminTelephone.Length == 0)
            {
                //return an error message
                Error = "the telephone must not be blank";
            }
            if (AdminTelephone.Length > 11)
            {
                //error
                Error = Error + "The telehone number cannot have more than 11 characters ";
            }


            if (AdminEmail.Length < 5)
            {
                //return an error message
                Error = "the email must not be blank";
            }
            if (AdminEmail.Length > 50)
            {
                //error
                Error = Error + "The Admin email cannot have more than 50 characters ";
            }

            //Password Validation//////////////////////////////////
            //if password has less than 8 characters
            if (AdminPassword.Length < 8)
            {
                //error msg
                Error = "Password must be at least 8 characters" + "<br />";
            }
            if (AdminPassword.Length > 50)
            {
                Error = "Password must be at least 50 characters" + "<br />";
            }
           

            return Error;
        }


    }

}