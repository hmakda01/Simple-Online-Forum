using System;

namespace OnlineForumClasses
{
    public class clsPost
    {

        private Int32 mPostId;
        private string mPostTitle;
        private string mPostDescription;
        private DateTime mPostDate;


        public clsPost()
        {
        }

        public int PostId
        {
            get
            {
                return mPostId;
            }
            set
            {
                mPostId = value;
            }
        }
        public string PostTitle
        {
            get
            {
                return mPostTitle;

            }
            set
            {
                mPostTitle = value;
            }
        }
        public string PostDescription
        {
            get
            {
                return mPostDescription;
            }
            set
            {
                mPostDescription = value;
            }
        }
        public DateTime PostDate
        {
            get
            {
                return mPostDate;
            }
            set
            {
                mPostDate = value;
            }
        }

        public bool Find(int PostId)
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paramerers for the stored rocudure
            DB.AddParameter("@PostId", PostId);
            //execute the stored procudure
            DB.Execute("sproc_tblPost_FilterByPostId");
            //if one record is found
            if (DB.Count == 1)
            {
                //set the private data member to the test data
                mPostId = Convert.ToInt32(DB.DataTable.Rows[0]["PostId"]);
                mPostTitle = Convert.ToString(DB.DataTable.Rows[0]["PostTitle"]);
                mPostDescription = Convert.ToString(DB.DataTable.Rows[0]["PostDescription"]);
                mPostDate = Convert.ToDateTime(DB.DataTable.Rows[0]["PostDate"]);
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



        public string Valid(string postTitle, string postDescription, string postDate)
        {
            //string variable to store error message
            String Error = "";

            DateTime DateTemp;

            //if the name of the staffis not blank
            if (postTitle.Length == 0)
            {
                //return an error message
                Error = "the name may not be blank";
            }
            if (postTitle.Length > 25)
            {
                //error
                Error = Error + "The staff name cannot have more than 25 characters ";
            }
            if (postDescription.Length == 0)
            {
                //return an error message
                Error = "the name may not be blank";
            }
            if (postDescription.Length > 100)
            {
                //error
                Error = Error + "The staff name cannot have more than 25 characters ";
            }
           

            try
            {
                DateTemp = Convert.ToDateTime(postDate);

                DateTime minDate = new DateTime(1970, 01, 01);
                DateTime maxDate = DateTime.Today;


                if (DateTemp < minDate || DateTemp > maxDate)

                {
                    //record the error
                    Error = Error + "The date must be between 1970 : " + maxDate;

                }


            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }

            return Error;
        }

      
    }
}