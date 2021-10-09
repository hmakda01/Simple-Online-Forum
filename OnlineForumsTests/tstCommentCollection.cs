using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineForumClasses;
using System.Collections.Generic;

namespace OnlineForumsTests
{
    [TestClass]
    public class tstCommentCollection
    {

        public void InstanceOK()
        {
            clsComment AllComment = new clsComment();
            Assert.IsNotNull(AllComment);
        }

        [TestMethod]
        public void CommentListOK()
        {
            //cretae an instance of the class we want to create
            clsCommentCollection AllComment = new clsCommentCollection();
            //create some test dat to assign to thwe property
            //in this case the data needs to be a list of objects
            List<clsComment> TestList = new List<clsComment>();
            //add a item to the ;list
            //cretae the item of test data
            clsComment TestItem = new clsComment();
            //set its properties
            TestItem.CommentId = 1;
            TestItem.CommentDescription = "";
            TestItem.CommentDate = DateTime.Now.Date;
            //ad the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllComment.CommentList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllComment.CommentList, TestList);

        }


        [TestMethod]

        public void ThisCommentPropertyOK()
        {
            clsCommentCollection AllComment = new clsCommentCollection();
            clsComment TestComment = new clsComment();
            //set its properties
            TestComment.CommentId = 1;
           // TestComment.HealthSpecialistId = 1;
            TestComment.CommentDescription = "";
            TestComment.CommentDate = DateTime.Now.Date;
            //assign the data to the property
            AllComment.ThisComment = TestComment;
            //test to see that the two values are the same
            Assert.AreEqual(AllComment.ThisComment, TestComment);
        }

        [TestMethod]
        public void AddMethodOk()
        {
            //create an instance of the class we want to create
            clsCommentCollection AllComment = new clsCommentCollection();
            //cretae the item of test data
            clsComment TestItem = new clsComment();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //tets it properties
            //set its properties
            TestItem.CommentDescription = "Please wear a mask and always santiza your hads to avoid spreading of germs ";
            TestItem.CommentDate = DateTime.Now.Date;
            //set thr Comment to the test data
            AllComment.ThisComment = TestItem;
            //add the record
            PrimaryKey = AllComment.Add();
            //set the primary key tpo the dtaa
            TestItem.CommentId = PrimaryKey;
            //find the record
            AllComment.ThisComment.Find(PrimaryKey);
            //TEST TO SEE IF THE TWO VLAUES ARE THE SAME 
            Assert.AreEqual(AllComment.ThisComment, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOk()
        {
            //create an instance of the class we want to create
            clsCommentCollection AllComment = new clsCommentCollection();
            //cretae the item of test data
            clsComment TestItem = new clsComment();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //tets it properties
            //set its properties
            TestItem.CommentDescription = "Please wear a mask and always santiza your hads to avoid spreading of germs";
            TestItem.CommentDate = DateTime.Now.Date;
            //set thr Comment to the test data
            AllComment.ThisComment = TestItem;
            //add the record
            PrimaryKey = AllComment.Add();
            //set the primary key tpo the dtaa
            TestItem.CommentId = PrimaryKey;
            //find the record
            AllComment.ThisComment.Find(PrimaryKey);
            //delete the record
            AllComment.Delete();
            //nw ind the ecord
            Boolean Found = AllComment.ThisComment.Find(PrimaryKey);
            //TEST TO SEEthat the reocrd is found
            Assert.IsFalse(Found);

        }


        [TestMethod]

        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCommentCollection AllComment = new clsCommentCollection();
            //cretae the item of test data
            clsComment TestItem = new clsComment();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //tets it properties
            //set its properties
            TestItem.CommentDescription = "wear a mask ";
            TestItem.CommentDate = DateTime.Now.Date;
            //set thr Comment to the test data
            AllComment.ThisComment = TestItem;
            //add the record
            PrimaryKey = AllComment.Add();
            //set the primary key tpo the dtaa
            TestItem.CommentId = PrimaryKey;
            //Modify the records
            TestItem.CommentDescription = "you can go to a drive up testing site so you don’t have to get out of your car! If you have those symptoms you most likely have Covid. . take care of yourself and stay hydrated!";
            TestItem.CommentDate = DateTime.Now.Date;
            //set thr Comment to the test data
            AllComment.ThisComment = TestItem;
            //update the record
            AllComment.Update();
            //find the record
            AllComment.ThisComment.Find(PrimaryKey);
            //TEST TO SEEthat the reocrd is found
            Assert.AreEqual(AllComment.ThisComment, TestItem);
        }

    }
}
