using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineForumClasses;
using System.Collections.Generic;

namespace OnlineForumsTests
{
    [TestClass]
    public class tstPostCollection
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void InstanceOK()
        {
            clsPostCollection AllPost = new clsPostCollection();
            Assert.IsNotNull(AllPost);
        }

        [TestMethod]
        public void PostListOK()
        {
            //cretae an instance of the class we want to create
            clsPostCollection AllPost = new clsPostCollection();
            //create some test dat to assign to thwe property
            //in this case the data needs to be a list of objects
            List<clsPost> TestList = new List<clsPost>();
            //add a item to the ;list
            //cretae the item of test data
            clsPost TestItem = new clsPost();
            //set its properties
            TestItem.PostId = 1;
            TestItem.PostTitle = "";
            TestItem.PostDescription = "";
            TestItem.PostDate = DateTime.Now.Date; 
            //ad the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllPost.PostList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllPost.PostList, TestList);

        }


        [TestMethod]

        public void ThisPostPropertyOK()
        {
            clsPostCollection AllPost = new clsPostCollection();
            clsPost TestPost = new clsPost();
            //set its properties
            TestPost.PostId = 1;
            TestPost.PostTitle = "";
            TestPost.PostDescription = "";
            TestPost.PostDate = DateTime.Now.Date;
            //assign the data to the property
            AllPost.ThisPost = TestPost;
            //test to see that the two values are the same
            Assert.AreEqual(AllPost.ThisPost, TestPost);
        }

        [TestMethod]
        public void AddMethodOk()
        {
            //create an instance of the class we want to create
            clsPostCollection AllPost = new clsPostCollection();
            //cretae the item of test data
            clsPost TestItem = new clsPost();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //tets it properties
            //set its properties
            //TestItem.PostId = 7;
            TestItem.PostTitle = "Feeling Ill";
            TestItem.PostDescription = "Hi i am currently 4 weeks post covid and feel worse now than when i had covid. I have a terribly dry throat and occasional cough. My mouth and tongue sting and it might sound weird but my tongue feels heavy in my mouth.";
            TestItem.PostDate = DateTime.Now.Date;
            //set thr Post to the test data
            AllPost.ThisPost = TestItem;
            //add the record
            PrimaryKey = AllPost.Add();
            //set the primary key tpo the dtaa
            TestItem.PostId = PrimaryKey;
            //find the record
            AllPost.ThisPost.Find(PrimaryKey);
            //TEST TO SEE IF THE TWO VLAUES ARE THE SAME 
            Assert.AreEqual(AllPost.ThisPost, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOk()
        {
            //create an instance of the class we want to create
            clsPostCollection AllPost = new clsPostCollection();
            //cretae the item of test data
            clsPost TestItem = new clsPost();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //tets it properties
            //set its properties
            // TestItem.PostId = 8;
            TestItem.PostTitle = "";
            TestItem.PostDescription= "";
            TestItem.PostDate = DateTime.Now.Date;
            //set thr Post to the test data
            AllPost.ThisPost = TestItem;
            //add the record
            PrimaryKey = AllPost.Add();
            //set the primary key tpo the dtaa
            TestItem.PostId = PrimaryKey;
            //find the record
            AllPost.ThisPost.Find(PrimaryKey);
            //delete the record
            AllPost.Delete();
            //nw ind the ecord
            Boolean Found = AllPost.ThisPost.Find(PrimaryKey);
            //TEST TO SEEthat the reocrd is found
            Assert.IsFalse(Found);

        }

        [TestMethod]

        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsPostCollection AllPost = new clsPostCollection();
            //cretae the item of test data
            clsPost TestItem = new clsPost();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //tets it properties
            //set its properties
            // TestItem.PostId = 8;
            TestItem.PostTitle = "";
            TestItem.PostDescription = "";
            TestItem.PostDate = DateTime.Now.Date;
            //set thr Post to the test data
            AllPost.ThisPost = TestItem;
            //add the record
            PrimaryKey = AllPost.Add();
            //set the primary key tpo the dtaa
            TestItem.PostId = PrimaryKey;
            //Modify the records
            TestItem.PostTitle = "Covid symptoms";
            TestItem.PostDescription = "Hi i am currently 4 weeks post covid and feel worse now than when i had covid. I have a terribly dry throat and occasional cough. My mouth and tongue sting and it might sound weird but my tongue feels heavy in my mouth.";
            TestItem.PostDate = DateTime.Now.Date;
            //set thr Post to the test data
            AllPost.ThisPost = TestItem;
            //update the record
            AllPost.Update();
            //find the record
            AllPost.ThisPost.Find(PrimaryKey);
            //TEST TO SEEthat the reocrd is found
            Assert.AreEqual(AllPost.ThisPost, TestItem);
        }


    }
}
