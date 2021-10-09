using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineForumClasses;

namespace OnlineForumsTests
{
    [TestClass]
    public class tstPost
    {

        string PostTitle = "Corona";
        string PostDescription = "fhudfudhf";
        string PostDate = DateTime.Now.Date.ToString();

        [TestMethod]
        public void TestMethod1()
        {
        }

        public void InstanceOk()
        {
            //create an instance of the class
            clsPost APost = new clsPost();
            //test to see of it exists
            Assert.IsNotNull(APost);
        }

        [TestMethod]
        
        public void PostIdOk()
        {
            clsPost APost = new clsPost();
            Int32 TestData = 1;
            //assgn the data to the property
            APost.PostId = TestData;
            //applythe test
            Assert.AreEqual(APost.PostId, TestData);

        }

        [TestMethod]
        public void PostTitleOK()
        {
            clsPost APost = new clsPost();
            //create some tests data
            string TestData = "Symptoms";
            //assign the data to the property
            APost.PostTitle = TestData;
            //test tpos ee if it works
            Assert.AreEqual(APost.PostTitle, TestData);
        }

        [TestMethod]
        public void PostDescriptionOK()
        {
            clsPost APost = new clsPost();
            //create some tests data
            string TestData = "clod, flu, loss of test";
            //assign the data to the property
            APost.PostDescription = TestData;
            //test tpos ee if it works
            Assert.AreEqual(APost.PostDescription, TestData);
        }

        [TestMethod]

        public void PostDateOK()
        {
            clsPost APost = new clsPost();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            APost.PostDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(APost.PostDate, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an intance of the class
            clsPost APost = new clsPost();
            //boolean varaubel ti stroe thge result of the validation
            Boolean Found = false;
            //create some test data to use
            Int32 PostId = 73;
            //invoke the method
            Found = APost.Find(PostId);
            //test to see if the result is ok
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestPostIdFound()
        {
            //create an intance of the class
            clsPost APost = new clsPost();
            //boolean varaubel ti stroe thge result of the validation
            Boolean Found = false;
            //boolea variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PostId = 73;
            //invoke the method
            Found = APost.Find(PostId);
            //check the Postid
            if (APost.PostId != 73)
            {
                OK = false;
            }
            //test to see if tis ok
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestPostTitleFound()
        {
            //create an intance of the class
            clsPost APost = new clsPost();
            //boolean varaubel ti stroe thge result of the validation
            Boolean Found = false;
            //boolea variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PostId = 73;
            //invoke the method
            Found = APost.Find(PostId);
            //check the Postid
            if (APost.PostTitle != "Vaccine")
            {
                OK = false;
            }
            //test to see if tis ok
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestPostDescriptionFound()
        {
            //create an intance of the class
            clsPost APost = new clsPost();
            //boolean varaubel ti stroe thge result of the validation
            Boolean Found = false;
            //boolea variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PostId = 73;
            //invoke the method
            Found = APost.Find(PostId);
            //check the Postid
            if (APost.PostDescription != "Does anybody know why over 55/60 can have the AstraZeneca injection in countries concerned with blood clots? Can they not get blood clots?")
            {
                OK = false;
            }
            //test to see if tis ok
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestPostDateFound()
        {
            //create an intance of the class
            clsPost APost = new clsPost();
            //boolean varaubel ti stroe thge result of the validation
            Boolean Found = false;
            //boolea variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PostId = 73;
            //invoke the method
            Found = APost.Find(PostId);
            //check the Postid
           
            if (APost.PostDate != Convert.ToDateTime("29/04/2021"))
            {
                OK = false;
            }
            //test to see if tis ok
            Assert.IsTrue(OK);

        }







        [TestMethod]

        public void ValidMethodOk()
        {
            clsPost APost = new clsPost();
            //cretae a stirng variavle to store the result
            String Error = "";
            //create some test data
            string PostTitle = "Corona";
            //invoke the method
            Error = APost.Valid(PostTitle, PostDescription, PostDate);
            //test to se if its ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void PostTitleMinLessOne()
        {
            clsPost APost = new clsPost();
            String Error = "";
            string PostTitle = "";
            Error = APost.Valid(PostTitle, PostDescription, PostDate);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PostTitleMinBoundary()
        {
            //cretae an instance of the class we want to create
            clsPost APost = new clsPost();
            //create astring variable to store it
            String Error = "";
            //create some test dat
            string PostTitle = "a";
            //invoke the methoid
            Error = APost.Valid(PostTitle, PostDescription, PostDate);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostTitleMinPlusOne()
        {
            //cretae an instance of the class we want to create
            clsPost APost = new clsPost();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string PostTitle = "aa";
            //invoke the methoid
            Error = APost.Valid(PostTitle, PostDescription, PostDate);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostTitleMaxLessOne()
        {
            //cretae an instance of the class we want to create
            clsPost APost = new clsPost();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string PostTitle = "kkkkkkkkkkkkkkkkkkkkkkkkk";
            //invoke the methoid
            Error = APost.Valid(PostTitle, PostDescription, PostDate);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostTitleMaxPlusOne()
        {
            //cretae an instance of the class we want to create
            clsPost APost = new clsPost();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string PostTitle = "oooooooooooooooooooooooooo";
            //invoke the methoid
            Error = APost.Valid(PostTitle, PostDescription, PostDate);
            //tets tosee if the result is no ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostTitleMid()
        {
            //cretae an instance of the class we want to create
            clsPost APost = new clsPost();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string PostTitle = "0123456789";
            //invoke the methoid
            Error = APost.Valid(PostTitle, PostDescription, PostDate);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostTitleExtremeMax()
        {
            //cretae an instance of the class we want to create
            clsPost APost = new clsPost();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string PostTitle = "";
            //pad the string with chracters
            PostTitle = PostTitle.PadRight(500, 'a');
            //invoke the methoid
            Error = APost.Valid(PostTitle, PostDescription, PostDate);
            //tets tosee if the result is not  ok
            Assert.AreNotEqual(Error, "");
        }

           [TestMethod]

        public void PostDescriptionMinLessOne()
        {
            clsPost APost = new clsPost();
            String Error = "";
            string PostDescription = "";
            Error = APost.Valid(PostTitle, PostDescription, PostDate);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PostDescriptionMinBoundary()
        {
            //cretae an instance of the class we want to create
            clsPost APost = new clsPost();
            //create astring variable to store it
            String Error = "";
            //create some test dat
            string PostDescription = "a";
            //invoke the methoid
            Error = APost.Valid(PostTitle, PostDescription, PostDate);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostDescriptionMinPlusOne()
        {
            //cretae an instance of the class we want to create
            clsPost APost = new clsPost();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string PostDescription = "aa";
            //invoke the methoid
            Error = APost.Valid(PostTitle, PostDescription, PostDate);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostDescriptionMaxLessOne()
        {
            //cretae an instance of the class we want to create
            clsPost APost = new clsPost();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string PostDescription = "lllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllll";
            //invoke the methoid
            Error = APost.Valid(PostTitle, PostDescription, PostDate);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostDescriptionMaxPlusOne()
        {
            //cretae an instance of the class we want to create
            clsPost APost = new clsPost();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string PostDescription = "lllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllll11";
            //invoke the methoid
            Error = APost.Valid(PostTitle, PostDescription, PostDate);
            //tets tosee if the result is no ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostDescriptionMid()
        {
            //cretae an instance of the class we want to create
            clsPost APost = new clsPost();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string PostDescription = "11111111111111111111111111111111111111111111111111";
            //invoke the methoid
            Error = APost.Valid(PostTitle, PostDescription, PostDate);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostDescriptionExtremeMax()
        {
            //cretae an instance of the class we want to create
            clsPost APost = new clsPost();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string PostDescription = "";
            //pad the string with chracters
            PostDescription = PostDescription.PadRight(500, 'a');
            //invoke the methoid
            Error = APost.Valid(PostTitle, PostDescription, PostDate);
            //tets tosee if the result is not  ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostDateMin()
        {
            //create an instance of the class we want to create
            clsPost APost = new clsPost();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string PostDate = TestDate.ToString();
            //invoke the method
            Error = APost.Valid(PostTitle, PostDescription, PostDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PostDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPost APost = new clsPost();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string PostDate = TestDate.ToString();
            //invoke the method
            Error = APost.Valid(PostTitle, PostDescription, PostDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsPost APost = new clsPost();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string PostDate = TestDate.ToString();
            //invoke the method
            Error = APost.Valid(PostTitle, PostDescription, PostDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostDateInvalidData()
        {
            //create an instance of the class we want to create
            clsPost APost = new clsPost();
            //string variable to store any error message
            String Error = "";
            //convert the date variable to a string variable
            string PostDate = "this is not a date!";
            //invoke the method
            Error = APost.Valid(PostTitle, PostDescription, PostDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}
