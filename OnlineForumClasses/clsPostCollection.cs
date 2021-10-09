using System.Collections.Generic;
using System;
namespace OnlineForumClasses
{
    public class clsPostCollection
    {
        private List<clsPost> mPostList = new List<clsPost>();
        clsPost mThisPost = new clsPost();
        public List<clsPost> PostList
        {
            get
            {
                return mPostList;
            }

            set
            {
                mPostList = value;
            }
        }


        //public property for cout
        public int Count
        {
            get
            {
                //return the count list
                return mPostList.Count;
            }
            set
            {
                //later
            }
        }


        public clsPost ThisPost
        {
            get
            {
                //retturn the private data
                return mThisPost;
            }

            set
            {
                mThisPost = value;
            }
        }

        public clsPostCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the rcord count
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            //exeucte the stored procudure
            DB.Execute("sproc_tblPost_SelectAll");
            //get th oucnt of the records
            RecordCount = DB.Count;
            //while records to process
            while (Index < RecordCount)
            {
                clsPost AnPost = new clsPost();
                AnPost.PostId = Convert.ToInt32(DB.DataTable.Rows[Index]["PostId"]);
                AnPost.PostTitle = Convert.ToString(DB.DataTable.Rows[Index]["PostTitle"]);
                AnPost.PostDescription = Convert.ToString(DB.DataTable.Rows[Index]["PostDescription"]);
                AnPost.PostDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["PostDate"]);
                //add the reocrd to the private data
                mPostList.Add(AnPost);
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
            DB.AddParameter("PostTitle", ThisPost.PostTitle);
            DB.AddParameter("PostDescription", ThisPost.PostDescription);
            DB.AddParameter("PostDate", ThisPost.PostDate);
            //execute the qeury
            return DB.Execute("sproc_tblPost_Insert");
        }

        public void Delete()
        {
            //deleted the record pointed to by ThisPost
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paramerers for the stored rocudure
            DB.AddParameter("@PostId", mThisPost.PostId);
            //execute the stored procudure
            DB.Execute("sproc_tblPost_Delete");


        }

        public void Update()
        {
            //updates a xisting reocrd to the databse
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the stroed procudure
            DB.AddParameter("PostId", mThisPost.PostId);
            DB.AddParameter("PostTitle", mThisPost.PostTitle);
            DB.AddParameter("PostDescription", mThisPost.PostDescription);
            DB.AddParameter("PostDate", mThisPost.PostDate);
            //execute the qeury
            DB.Execute("sproc_tblPost_Update");
        }

    }






}