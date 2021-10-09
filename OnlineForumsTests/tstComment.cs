using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineForumClasses;

namespace OnlineForumsTests
{
    [TestClass]
    public class tstComment
    {
        
        string CommentDescription = "fhudfudhf";
        string CommentDate = DateTime.Now.Date.ToString();

        [TestMethod]

        public void InstanceOK()
        {
            clsComment AComment = new clsComment();
            Assert.IsNotNull(AComment);
        }

        [TestMethod]

        public void CommentIdOk()
        {
            clsComment AComment = new clsComment();
            Int32 TestData = 1;
            //assgn the data to the property
            AComment.CommentId = TestData;
            //applythe test
            Assert.AreEqual(AComment.CommentId, TestData);

        }

       


        [TestMethod]
        public void CommentDescriptionOK()
        {
            clsComment AComment = new clsComment();
            //create some tests data
            string TestData = "";
            //assign the data to the property
            AComment.CommentDescription = TestData;
            //test tpos ee if it works
            Assert.AreEqual(AComment.CommentDescription, TestData);
        }

        [TestMethod]

        public void CommentDateOK()
        {
            clsComment AComment = new clsComment();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AComment.CommentDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AComment.CommentDate, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an intance of the class
            clsComment AComment = new clsComment();
            //boolean varaubel ti stroe thge result of the validation
            Boolean Found = false;
            //create some test data to use
            Int32 CommentId = 30;
            //invoke the method
            Found = AComment.Find(CommentId);
            //test to see if the result is ok
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCommentIdFound()
        {
            //create an intance of the class
            clsComment AComment = new clsComment();
            //boolean varaubel ti stroe thge result of the validation
            Boolean Found = false;
            //boolea variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CommentId = 30;
            //invoke the method
            Found = AComment.Find(CommentId);
            //check the Commentid
            if (AComment.CommentId != 30)
            {
                OK = false;
            }
            //test to see if tis ok
            Assert.IsTrue(OK);

        }


    

        [TestMethod]
        public void TestCommentDescriptionFound()
        {
            //create an intance of the class
            clsComment AComment = new clsComment();
            //boolean varaubel ti stroe thge result of the validation
            Boolean Found = false;
            //boolea variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CommentId = 30;
            //invoke the method
            Found = AComment.Find(CommentId);
            //check the Commentid
            if (AComment.CommentDescription != "Stay Indoors")
            {
                OK = false;
            }
            //test to see if tis ok
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestCommentDateFound()
        {
            //create an intance of the class
            clsComment AComment = new clsComment();
            //boolean varaubel ti stroe thge result of the validation
            Boolean Found = false;
            //boolea variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CommentId = 30;
            //invoke the method
            Found = AComment.Find(CommentId);
            //check the Commentid

            if (AComment.CommentDate != Convert.ToDateTime("09/03/2021"))
            {
                OK = false;
            }
            //test to see if tis ok
            Assert.IsTrue(OK);

        }


        [TestMethod]

        public void ValidMethodOk()
        {
            clsComment AComment = new clsComment();
            //cretae a stirng variavle to store the result
            String Error = "";
            //create some test data
            string CommentDescription = "ujyjuujj";
            //invoke the method
            Error = AComment.Valid(CommentDescription, CommentDate);
            //test to se if its ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CommentDescriptionMinLessOne()
        {
            clsComment AComment = new clsComment();
            String Error = "";
            string CommentDescription = "";
            Error = AComment.Valid(CommentDescription, CommentDate);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CommentDescriptionMinBoundary()
        {
            //cretae an instance of the class we want to create
            clsComment AComment = new clsComment();
            //create astring variable to store it
            String Error = "";
            //create some test dat
            string CommentDescription = "a";
            //invoke the methoid
            Error = AComment.Valid(CommentDescription, CommentDate);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CommentDescriptionMinPlusOne()
        {
            //cretae an instance of the class we want to create
            clsComment AComment = new clsComment();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string CommentDescription = "aa";
            //invoke the methoid
            Error = AComment.Valid(CommentDescription, CommentDate);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CommentDescriptionMaxLessOne()
        {
            //cretae an instance of the class we want to create
            clsComment AComment = new clsComment();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string CommentDescription = "lllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllll";
            //invoke the methoid
            Error = AComment.Valid(CommentDescription, CommentDate);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CommentDescriptionMaxPlusOne()
        {
            //cretae an instance of the class we want to create
            clsComment AComment = new clsComment();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string CommentDescription = "lllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllll11";
            //invoke the methoid
            Error = AComment.Valid(CommentDescription, CommentDate);
            //tets tosee if the result is no ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CommentDescriptionMid()
        {
            //cretae an instance of the class we want to create
            clsComment AComment = new clsComment();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string CommentDescription = "11111111111111111111111111111111111111111111111111";
            //invoke the methoid
            Error = AComment.Valid(CommentDescription, CommentDate);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CommentDescriptionExtremeMax()
        {
            //cretae an instance of the class we want to create
            clsComment AComment = new clsComment();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string CommentDescription = "";
            //pad the string with chracters
            CommentDescription = CommentDescription.PadRight(500, 'a');
            //invoke the methoid
            Error = AComment.Valid(CommentDescription, CommentDate);
            //tets tosee if the result is not  ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CommentDateMin()
        {
            //create an instance of the class we want to create
            clsComment AComment = new clsComment();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string CommentDate = TestDate.ToString();
            //invoke the method
            Error = AComment.Valid(CommentDescription, CommentDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CommentDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsComment AComment = new clsComment();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string CommentDate = TestDate.ToString();
            //invoke the method
            Error = AComment.Valid(CommentDescription, CommentDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CommentDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsComment AComment = new clsComment();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string CommentDate = TestDate.ToString();
            //invoke the method
            Error = AComment.Valid(CommentDescription, CommentDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CommentDateInvalidData()
        {
            //create an instance of the class we want to create
            clsComment AComment = new clsComment();
            //string variable to store any error message
            String Error = "";
            //convert the date variable to a string variable
            string CommentDate = "this is not a date!";
            //invoke the method
            Error = AComment.Valid(CommentDescription, CommentDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



    }
}
