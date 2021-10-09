using System;

namespace OnlineForumClasses
{
    public class clsHealthSpecialist
    {
        private Int32 mHealthSpecialistId;
        private string mHealthSpecialistFirstName;
        private string mHealthSpecialistLastName;
        private string mHealthSpecialistTelephone;
        private string mHealthSpecialistEmail;
        private string mHealthSpecialistPassword;



        public int HealthSpecialistId
        {
            get
            {
                return mHealthSpecialistId;
            }

            set
            {
                //set the value of the data private data meber
                mHealthSpecialistId = value;
            }

        }
        public string HealthSpecialistFirstName
        {
            get
            {
                return mHealthSpecialistFirstName;
            }
            set
            {
                mHealthSpecialistFirstName = value;
            }
        }
        public string HealthSpecialistLastName
        {
            get
            {
                return mHealthSpecialistLastName;
            }
            set
            {
                mHealthSpecialistLastName = value;
            }
        }

        public string HealthSpecialistTelephone
        {
            get
            {
                return mHealthSpecialistTelephone;
            }
            set
            {
                mHealthSpecialistTelephone = value;
            }
        }
        public string HealthSpecialistEmail
        {
            get
            {
                return mHealthSpecialistEmail;
            }
            set
            {
                mHealthSpecialistEmail = value;
            }
        }

        public string HealthSpecialistPassword
        {
            get
            {
                return mHealthSpecialistPassword;
            }
            set
            {
                mHealthSpecialistPassword = value;
            }
        }

        public bool Find(int HealthSpecialistId)
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paramerers for the stored rocudure
            DB.AddParameter("@HealthSpecialistId", HealthSpecialistId);
            //execute the stored procudure
            DB.Execute("sproc_tblHealthSpecialist_FilterByHealthSpecialistId");
            //if one record is found
            if (DB.Count == 1)
            {
                //set the private data member to the test data
                mHealthSpecialistId = Convert.ToInt32(DB.DataTable.Rows[0]["HealthSpecialistId"]);
                mHealthSpecialistFirstName = Convert.ToString(DB.DataTable.Rows[0]["HealthSpecialistFirstName"]);
                mHealthSpecialistLastName = Convert.ToString(DB.DataTable.Rows[0]["HealthSpecialistLastName"]);
                mHealthSpecialistTelephone = Convert.ToString(DB.DataTable.Rows[0]["HealthSpecialistTelephone"]);
                mHealthSpecialistEmail = Convert.ToString(DB.DataTable.Rows[0]["HealthSpecialistEmail"]);
                mHealthSpecialistPassword = Convert.ToString(DB.DataTable.Rows[0]["HealthSpecialistPassword"]);
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



        public string Valid(string HealthSpecialistFirstName, string HealthSpecialistLastName, string HealthSpecialistTelephone, string HealthSpecialistEmail, string HealthSpecialistPassword)
        {
            //string variable to store error message
            String Error = "";


            //if the name of the HealthSpecialistis not blank
            if (HealthSpecialistFirstName.Length < 2)
            {
                //return an error message
                Error = "the name may not be blank";
            }
            if (HealthSpecialistFirstName.Length > 25)
            {
                //error
                Error = Error + "The HealthSpecialist name cannot have more than 25 characters ";
            }
            if (HealthSpecialistLastName.Length < 2)
            {
                //return an error message
                Error = "the name may not be blank";
            }
            if (HealthSpecialistLastName.Length > 25)
            {
                //error
                Error = Error + "The HealthSpecialist name cannot have more than 25 characters ";
            }
            if (HealthSpecialistTelephone.Length == 0)
            {
                //return an error message
                Error = "the name may not be blank";
            }
            if (HealthSpecialistTelephone.Length > 11)
            {
                //error
                Error = Error + "The HealthSpecialist name cannot have more than 25 characters ";
            }


            if (HealthSpecialistEmail.Length < 5)
            {
                //return an error message
                Error = "the name may not be blank";
            }
            if (HealthSpecialistEmail.Length > 50)
            {
                //error
                Error = Error + "The HealthSpecialistemail cannot have more than 50 characters ";
            }

            if (HealthSpecialistPassword.Length < 8)
            {
                //return an error message
                Error = "the name may not be blank";
            }
            if (HealthSpecialistPassword.Length > 50)
            {
                //error
                Error = Error + "The HealthSpecialistemail cannot have more than 50 characters ";
            }
            //if the name of the HealthSpecialistis not blank


            return Error;
        }

        public string ValidHealthSpecialist(string HealthSpecialistFirstName, string HealthSpecialistLastName, string HealthSpecialistTelephone, string HealthSpecialistEmail, string HealthSpecialistPassword)
        {
            //string variable to store error message
            String Error = "";


            //if the name of the HealthSpecialistis not blank
            if (HealthSpecialistFirstName.Length < 2)
            {
                //return an error message
                Error = "the name may not be blank";
            }
            if (HealthSpecialistFirstName.Length > 25)
            {
                //error
                Error = Error + "The HealthSpecialist name cannot have more than 25 characters ";
            }
            if (HealthSpecialistLastName.Length < 2)
            {
                //return an error message
                Error = "the name may not be blank";
            }
            if (HealthSpecialistLastName.Length > 25)
            {
                //error
                Error = Error + "The HealthSpecialist name cannot have more than 25 characters ";
            }
            if (HealthSpecialistTelephone.Length == 0)
            {
                //return an error message
                Error = "the name may not be blank";
            }
            if (HealthSpecialistTelephone.Length > 11)
            {
                //error
                Error = Error + "The HealthSpecialist name cannot have more than 25 characters ";
            }


            if (HealthSpecialistEmail.Length < 5)
            {
                //return an error message
                Error = "the name may not be blank";
            }
            if (HealthSpecialistEmail.Length > 50)
            {
                //error
                Error = Error + "The HealthSpecialistemail cannot have more than 50 characters ";
            }

            if (HealthSpecialistPassword.Length < 8)
            {
                //return an error message
                Error = "the name may not be blank";
            }
            if (HealthSpecialistPassword.Length > 50)
            {
                //error
                Error = Error + "The HealthSpecialistemail cannot have more than 50 characters ";
            }
            //if the name of the HealthSpecialistis not blank


            return Error;
        }


    }

}