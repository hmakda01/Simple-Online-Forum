using System;

namespace OnlineForumClasses
{
    public class clsComment
    {

        private Int32 mCommentId;
        private string mCommentDescription;
        private DateTime mCommentDate;

        public int CommentId
        {
            get
            {
                return mCommentId;
            }
            set
            {
                mCommentId = value;
            }
        }
  
        public string CommentDescription
        {
            get
            {
                return mCommentDescription;
            }
            set
            {
                mCommentDescription = value;
            }
        }
        public DateTime CommentDate
        {
            get
            {
                return mCommentDate;
            }
            set
            {
                mCommentDate = value;
            }
        }

        public bool Find(int CommentId)
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paramerers for the stored rocudure
            DB.AddParameter("@CommentId", CommentId);
            //execute the stored procudure
            DB.Execute("sproc_tblComment_FilterByCommentId");
            //if one record is found
            if (DB.Count == 1)
            {
                //set the private data member to the test data
                mCommentId = Convert.ToInt32(DB.DataTable.Rows[0]["CommentId"]);
                mCommentDescription = Convert.ToString(DB.DataTable.Rows[0]["CommentDescription"]);
                mCommentDate = Convert.ToDateTime(DB.DataTable.Rows[0]["CommentDate"]);
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


        public string Valid(string commentDescription, string commentDate)
        {
            //string variable to store error message
            String Error = "";

            DateTime DateTemp;

            // If the comment is not blank
         
            if (commentDescription.Length == 0)
            {
                //return an error message
                Error = "the description may not be blank";
            }
            if (commentDescription.Length > 100)
            {
                //error
                Error = Error + "The comment cannot have more than 100 characters ";
            }


            try
            {
                DateTemp = Convert.ToDateTime(commentDate);

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