using System.Collections.Generic;
using System;

namespace OnlineForumClasses
{
    public class clsCommentCollection
    {
        private List<clsComment> mCommentList = new List<clsComment>();
        clsComment mThisComment = new clsComment();
        public List<clsComment> CommentList
        {
            get
            {
                return mCommentList;
            }
            set
            {
                mCommentList = value;
            }
        }

        //public property for cout
        public int Count
        {
            get
            {
                //return the count list
                return mCommentList.Count;
            }
            set
            {
                //later
            }
        }


        public clsComment ThisComment
        {
            get
            {
                //retturn the private data
                return mThisComment;
            }

            set
            {
                mThisComment = value;
            }
        }

        public clsCommentCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the rcord count
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            //exeucte the stored procudure
            DB.Execute("sproc_tblComment_SelectAll");
            //get th oucnt of the records
            RecordCount = DB.Count;
            //while records to process
            while (Index < RecordCount)
            {
                clsComment AnComment = new clsComment();
                AnComment.CommentId = Convert.ToInt32(DB.DataTable.Rows[Index]["CommentId"]);
                AnComment.CommentDescription = Convert.ToString(DB.DataTable.Rows[Index]["CommentDescription"]);
                AnComment.CommentDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["CommentDate"]);
                //add the reocrd to the private data
                mCommentList.Add(AnComment);
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
            DB.AddParameter("CommentDescription", ThisComment.CommentDescription);
            DB.AddParameter("CommentDate", ThisComment.CommentDate);
            //execute the qeury
            return DB.Execute("sproc_tblComment_Insert");
        }

        public void Delete()
        {
            //deleted the record pointed to by ThisComment
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paramerers for the stored rocudure
            DB.AddParameter("@CommentId", mThisComment.CommentId);
            //execute the stored procudure
            DB.Execute("sproc_tblComment_Delete");


        }

        public void Update()
        {
            //updates a xisting reocrd to the databse
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the stroed procudure
            DB.AddParameter("CommentId", mThisComment.CommentId);
            DB.AddParameter("CommentDescription", mThisComment.CommentDescription);
            DB.AddParameter("CommentDate", mThisComment.CommentDate);
            //execute the qeury
            DB.Execute("sproc_tblComment_Update");
        }


    }
}