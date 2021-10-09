using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineForumClasses;

///Matthew Dean mjdean@dmu.ac.uk De Montfort University 2013

namespace OnlineForumsTests
{

   
    [TestClass]
    public class tstUser
    {
        string UserFirstName = "John";
        string UserLastName = "Smith";
        string UserTelephone = "01163480420";
        string UserEmail = "hfhggfh";
        string UserPassword = "Passowrd43";
      
        public void InstanceOk()
        {
            //create an instance of the class
            clsUser AUser = new clsUser();
            //test to see of it exists
            Assert.IsNotNull(AUser);
        }

        [TestMethod]
        public void UserId()
        {
            clsUser AUser = new clsUser();
            Int32 TestData = 1;
            //assgn the data to the property
            AUser.UserId = TestData;
            //applythe test
            Assert.AreEqual(AUser.UserId, TestData);
        }

        [TestMethod]
        public void UserFirstNameOK()
        {
            clsUser AUser = new clsUser();
            //create some tests data
            string TestData = "Husain";
            //assign the data to the property
            AUser.UserFirstName = TestData;
            //test tpos ee if it works
            Assert.AreEqual(AUser.UserFirstName, TestData);
        }

        [TestMethod]
        public void UserLastNameOK()
        {
            clsUser AUser = new clsUser();
            //create some tests data
            string TestData = "Makda";
            //assign the data to the property
            AUser.UserLastName = TestData;
            //test tpos ee if it works
            Assert.AreEqual(AUser.UserLastName, TestData);
        }

        [TestMethod]

        public void UserTelephoneOK()
        {
            clsUser AUser = new clsUser();
            //creat some test data
            string TestData = "07742776735";
            //assign a property
            AUser.UserTelephone = TestData;
            //test to see iof it works
            Assert.AreEqual(AUser.UserTelephone, TestData);
        }

    

        [TestMethod]
        public void UserEmailOK()
        {
            clsUser AUser = new clsUser();
            //create some tests data
            string TestData = "yeyeye@gmail.com";
            //assign the data to the property
            AUser.UserEmail = TestData;
            //test tpos ee if it works
            Assert.AreEqual(AUser.UserEmail, TestData);
        }

        [TestMethod] 

        public void UserPasswordOK()
        {
            clsUser AUser = new clsUser();
            //create some test data
            string TestData = "Passowrd12";
            //assign the data tot he property
            AUser.UserPassword = TestData;
            //test to see of it works
            Assert.AreEqual(AUser.UserPassword, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an intance of the class
            clsUser AUser = new clsUser();
            //boolean varaubel ti stroe thge result of the validation
            Boolean Found = false;
            //create some test data to use
            Int32 UserId =69;
            //invoke the method
            Found = AUser.Find(UserId);
            //test to see if the result is ok
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserIdFound()
        {
            //create an intance of the class
            clsUser AUser = new clsUser();
            //boolean varaubel ti stroe thge result of the validation
            Boolean Found = false;
            //boolea variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserId = 69;
            //invoke the method
            Found = AUser.Find(UserId);
            //check the Userid
            if (AUser.UserId != 69)
            {
                OK = false;
            }
            //test to see if tis ok
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestUserFirstNameFound()
        {
            //create an intance of the class
            clsUser AUser = new clsUser();
            //boolean varaubel ti stroe thge result of the validation
            Boolean Found = false;
            //boolea variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserId = 69;
            //invoke the method
            Found = AUser.Find(UserId);
            //check the Userid
            if (AUser.UserFirstName != "Frank")
            {
                OK = false;
            }
            //test to see if tis ok
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestUserLastNameFound()
        {
            //create an intance of the class
            clsUser AUser = new clsUser();
            //boolean varaubel ti stroe thge result of the validation
            Boolean Found = false;
            //boolea variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserId = 69;
            //invoke the method
            Found = AUser.Find(UserId);
            //check the Userid
            if (AUser.UserLastName != "Lampard")
            {
                OK = false;
            }
            //test to see if tis ok
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestUserTelephoneFound()
        {
            //create an intance of the class
            clsUser AUser = new clsUser();
            //boolean varaubel ti stroe thge result of the validation
            Boolean Found = false;
            //boolea variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserId = 69;
            //invoke the method
            Found = AUser.Find(UserId);
            //check the Userid
            if (AUser.UserTelephone != "07653214327")
            {
                OK = false;
            }
            //test to see if tis ok
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void TestUserEmailFound()
        {
            //create an intance of the class
            clsUser AUser = new clsUser();
            //boolean varaubel ti stroe thge result of the validation
            Boolean Found = false;
            //boolea variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserId = 69;
            //invoke the method
            Found = AUser.Find(UserId);
            //check the Userid
            if (AUser.UserEmail != "fl@gmail.com")
            {
                OK = false;
            }
            //test to see if tis ok
            Assert.IsTrue(OK);

        }

        [TestMethod]

        public void TestUserPasswordFound()
        {
            //create an instance of the new class
            clsUser AUser = new clsUser();
            //boolan varibale to store the result 
            Boolean Found = false;
            //boolea variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserId = 69;
            //invoke the method
            Found = AUser.Find(UserId);
            if (AUser.UserPassword != "blue8")
            {
                OK = false;
            }
            //test to see if tis ok
            Assert.IsTrue(OK);

        }


        //[TestMethod]

        //public void ValidMethodOk()
        //{
        //    clsUser AUser = new clsUser();
        //    //cretae a stirng variavle to store the result
        //    String Error = "";
        //    //create some test data
        //    string UserFirstName = "John";
        //    //invoke the method
        //    Error = AUser.Valid(UserFirstName, UserLastName, UserTelephone, UserEmail, UserPassword);
        //    //test to se if its ok
        //    Assert.AreEqual(Error, "");
        //}

        [TestMethod]

        public void UserFirstNameMinLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string UserFirstName = "a";
            Error = AUser.Valid(UserFirstName, UserLastName, UserTelephone, UserEmail, UserPassword);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void UserFirstNameMinBoundary()
        {
            //cretae an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create astring variable to store it
            String Error = "";
            //create some test dat
            string UserFirstName = "aa";
            //invoke the methoid
            Error = AUser.Valid(UserFirstName, UserLastName, UserTelephone, UserEmail, UserPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserFirstNameMinPlusOne()
        {
            //cretae an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string UserFirstName = "aaa";
            //invoke the methoid
            Error = AUser.Valid(UserFirstName, UserLastName, UserTelephone, UserEmail, UserPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserFirstNameMaxLessOne()
        {
            //cretae an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string UserFirstName = "kkkkkkkkkkkkkkkkkkkkkkkkk";
            //invoke the methoid
            Error = AUser.Valid(UserFirstName, UserLastName, UserTelephone, UserEmail, UserPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserFirstNameMaxPlusOne()
        {
            //cretae an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string UserFirstName = "oooooooooooooooooooooooooo";
            //invoke the methoid
            Error = AUser.Valid(UserFirstName, UserLastName, UserTelephone, UserEmail, UserPassword);
            //tets tosee if the result is no ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UserFirstNameMid()
        {
            //cretae an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string UserFirstName = "0123456789";
            //invoke the methoid
            Error = AUser.Valid(UserFirstName, UserLastName, UserTelephone, UserEmail, UserPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserFirstNameExtremeMax()
        {
            //cretae an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string UserFirstName = "";
            //pad the string with chracters
            UserFirstName = UserFirstName.PadRight(500, 'a');
            //invoke the methoid
            Error = AUser.Valid(UserFirstName, UserLastName, UserTelephone, UserEmail, UserPassword);
            //tets tosee if the result is not  ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void UserLastNameMinLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            string UserLastName = "a";
            Error = AUser.Valid(UserFirstName, UserLastName, UserTelephone, UserEmail, UserPassword);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void UserLastNameMinBoundary()
        {
            //cretae an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create astring variable to store it
            String Error = "";
            //create some test dat
            string UserLastName = "aa";
            //invoke the methoid
            Error = AUser.Valid(UserFirstName, UserLastName, UserTelephone, UserEmail, UserPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserLastNameMinPlusOne()
        {
            //cretae an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string UserLastName = "aaa";
            //invoke the methoid
            Error = AUser.Valid(UserFirstName, UserLastName, UserTelephone, UserEmail, UserPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserLastNameMaxLessOne()
        {
            //cretae an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string UserLastName = "kkkkkkkkkkkkkkkkkkkkkkkkk";
            //invoke the methoid
            Error = AUser.Valid(UserFirstName, UserLastName, UserTelephone, UserEmail, UserPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserLastNameMaxPlusOne()
        {
            //cretae an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string UserLastName = "oooooooooooooooooooooooooo";
            //invoke the methoid
            Error = AUser.Valid(UserFirstName, UserLastName, UserTelephone, UserEmail, UserPassword);
            //tets tosee if the result is no ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UserLastNameMid()
        {
            //cretae an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string UserLastName = "0123456789";
            //invoke the methoid
            Error = AUser.Valid(UserFirstName, UserLastName, UserTelephone, UserEmail, UserPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserLastNameExtremeMax()
        {
            //cretae an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string UserLastName = "";
            //pad the string with chracters
            UserLastName = UserLastName.PadRight(500, 'a');
            //invoke the methoid
            Error = AUser.Valid(UserFirstName, UserLastName, UserTelephone, UserEmail, UserPassword);
            //tets tosee if the result is not  ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UserTelephoneMinBoundary()
        {
            //cretae an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create astring variable to store it
            String Error = "";
            //create some test dat
            string UserTelephone = "4";
            //invoke the methoid
            Error = AUser.Valid(UserFirstName, UserLastName, UserTelephone, UserEmail, UserPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserTelephoneMinPlusOne()
        {
            //cretae an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string UserTelephone = "22";
            //invoke the methoid
            Error = AUser.Valid(UserFirstName, UserLastName, UserTelephone, UserEmail, UserPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserTelephoneNameMaxLessOne()
        {
            //cretae an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string UserTelephone = "1234567890";
            //invoke the methoid
            Error = AUser.Valid(UserFirstName, UserLastName, UserTelephone, UserEmail, UserPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserTelephoneMaxPlusOne()
        {
            //cretae an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string UserTelephone = "123456789012";
            //invoke the methoid
            Error = AUser.Valid(UserFirstName, UserLastName, UserTelephone, UserEmail, UserPassword);
            //tets tosee if the result is no ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UserTelephoneMid()
        {
            //cretae an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string UserTelephone = "12345";
            //invoke the methoid
            Error = AUser.Valid(UserFirstName, UserLastName, UserTelephone, UserEmail, UserPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserTelephoneExtremeMax()
        {
            //cretae an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string UserTelephone = "";
            //pad the string with chracters
            UserTelephone = UserTelephone.PadRight(500, 'a');
            //invoke the methoid
            Error = AUser.Valid(UserFirstName, UserLastName, UserTelephone, UserEmail, UserPassword);
            //tets tosee if the result is not  ok
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void UserEmailMinBoundary()
        {
            //cretae an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create astring variable to store it
            String Error = "";
            //create some test dat
            string UserEmail = "aaaaaa";
            //invoke the methoid
            Error = AUser.Valid(UserFirstName, UserLastName, UserTelephone, UserEmail, UserPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserEmailMinPlusOne()
        {
            //cretae an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string UserEmail = "aaaaaa";
            //invoke the methoid
            Error = AUser.Valid(UserFirstName, UserLastName, UserTelephone, UserEmail, UserPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserEmailMaxLessOne()
        {
            //cretae an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string UserEmail = "kkkkkkkkkkkkkkkkkkkkkkkk";
            //invoke the methoid
            Error = AUser.Valid(UserFirstName, UserLastName, UserTelephone, UserEmail, UserPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserEmaiMaxPlusOne()
        {
            //cretae an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string UserEmail = "llllllllllllllllllllllllllllllllllllllllllllllllll111";
            //invoke the methoid
            Error = AUser.Valid(UserFirstName, UserLastName, UserTelephone, UserEmail, UserPassword);
            //tets tosee if the result is no ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UserEmailMid()
        {
            //cretae an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string UserEmail = "0123456@789";
            //invoke the methoid
            Error = AUser.Valid(UserFirstName, UserLastName, UserTelephone, UserEmail, UserPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void UserEmailExtremeMax()
        {
            //cretae an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string UserEmail = "";
            //pad the string with chracters
            UserEmail = UserEmail.PadRight(500, 'a');
            //invoke the methoid
            Error = AUser.Valid(UserFirstName, UserLastName, UserTelephone, UserEmail, UserPassword);
            //tets tosee if the result is not  ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UserPasswordMinBoundary()
        {
            //cretae an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create astring variable to store it
            String Error = "";
            //create some test dat
            string UserPassword = "aaaaaaaa";
            //invoke the methoid
            Error = AUser.Valid(UserFirstName, UserLastName, UserTelephone, UserEmail, UserPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserPasswordMinPlusOne()
        {
            //cretae an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string UserPassword = "aaaaaaaaa";
            //invoke the methoid
            Error = AUser.Valid(UserFirstName, UserLastName, UserTelephone, UserEmail, UserPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserPasswordMaxLessOne()
        {
            //cretae an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string UserPassword = "kkkkkkkkkkkkkkkkkkkkkkkk";
            //invoke the methoid
            Error = AUser.Valid(UserFirstName, UserLastName, UserTelephone, UserEmail, UserPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserPasswordMaxPlusOne()
        {
            //cretae an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string UserPassword = "llllllllllllllllllllllllllllllllllllllllllllllllll111";
            //invoke the methoid
            Error = AUser.Valid(UserFirstName, UserLastName, UserTelephone, UserEmail, UserPassword);
            //tets tosee if the result is no ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UserPasswordMid()
        {
            //cretae an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string UserPassword = "0123456i789";
            //invoke the methoid
            Error = AUser.Valid(UserFirstName, UserLastName, UserTelephone, UserEmail, UserPassword);
            //tets tosee if the result is  ok
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void UserPasswordExtremeMax()
        {
            //cretae an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create astring variable to store it
            String Error = "";
            //create some test data
            string UserPassword = "";
            //pad the string with chracters
            UserPassword = UserPassword.PadRight(500, 'a');
            //invoke the methoid
            Error = AUser.Valid(UserFirstName, UserLastName, UserTelephone, UserEmail, UserPassword);
            //tets tosee if the result is not  ok
            Assert.AreNotEqual(Error, "");
        }



    }


    

}





