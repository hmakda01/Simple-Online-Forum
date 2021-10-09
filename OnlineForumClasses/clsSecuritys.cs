using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using OnlineForumClasses;


namespace OnlineForumClasses
{
    public class clsSecuritys
    {
        //private data members
        private string mUserEmail = "";
        private string mAdminEmail = "";
        private string mHealthSpecialistEmail = "";
        //indicates if it is an admin

        //constructor
        public clsSecuritys()
        {

        }

        //allows access to the email of the current User
        public string UserEmail
        {
            get
            {
                //return Email
                return mUserEmail;
            }
        }


        //allows access to the email of the current User
        public string AdminEmail
        {
            get
            {
                //return Email
                return mAdminEmail;
            }
        }

        public string HealthSpecialistEmail
        {
            get
            {
                // Return Email
                return mHealthSpecialistEmail;
            }
        }

        public string UserSignIn(string UserEmail, string UserPassword)
        {
            //sign in a User based on their Email and password
            //if not all attemps are used
            string Error = "";
            //convert plain text password to hash code
            UserPassword = GetHashString(UserPassword + UserEmail);
            //find the matching record
            clsDataConnection UserAccount = new clsDataConnection();
            //add the parameter
            UserAccount.AddParameter("@UserEmail", UserEmail);
            UserAccount.AddParameter("@UserPassword", UserPassword);
            //execute stored procedure
            UserAccount.Execute("sproc_tblUser_FilterByUserEmailAndPassword");
            //if there is one record found
            if (UserAccount.Count >= 1)
            {
                Error = "";
            }
            else
            {
                Error = "There were problems with the sign in";
            }
            return Error;

        }

        public string AdminSignIn(string AdminEmail, string AdminPassword)
        {
            //sign in a User based on their Email and password
            //if not all attemps are used
            string Error = "";
            //convert plain text password to hash code
            AdminPassword = GetHashString(AdminPassword + AdminEmail);
            //find the matching record
            clsDataConnection UserAccount = new clsDataConnection();
            //add the parameter
            UserAccount.AddParameter("@AdminEmail", AdminEmail);
            UserAccount.AddParameter("@AdminPassword", AdminPassword);
            //execute stored procedure
            UserAccount.Execute("sproc_tblAdmin_FilterByAdminEmailAndPassword");
            //if there is one record found
            if (UserAccount.Count >= 1)
            {
                Error = "";
            }
            else
            {
                Error = "There were problems with the sign in";
            }
            return Error;

        }

        public string HealthSpecialistSignIn(string HealthSpecialistEmail, string HealthSpecialistPassword)
        {
            //sign in a User based on their Email and password
            //if not all attemps are used
            string Error = "";
            //convert plain text password to hash code
            HealthSpecialistPassword = GetHashString(HealthSpecialistPassword + HealthSpecialistEmail);
            //find the matching record
            clsDataConnection UserAccount = new clsDataConnection();
            //add the parameter
            UserAccount.AddParameter("@HealthSpecialistEmail", HealthSpecialistEmail);
            UserAccount.AddParameter("@HealthSpecialistPassword", HealthSpecialistPassword);
            //execute stored procedure
            UserAccount.Execute("sproc_tblHealthSpecialist_FilterByHealthSpecialistEmailAndPassword");
            //if there is one record found
            if (UserAccount.Count >= 1)
            {
                Error = "";
            }
            else
            {
                Error = "There were problems with the sign in";
            }
            return Error;

        }


        private string GetHashString(string SomeText)
        {
            //generates a hash for storing secure data in the database
            if (SomeText != "")//if there is text to process
            {
                //create an instance of the hash generator
                SHA256Managed HashGenerator = new SHA256Managed();
                //var to store the final hash
                string HashString;
                //array to store the bytes of the orignal text
                byte[] TextBytes;
                //array to store the bytes of the new hash
                byte[] HashBytes;
                //convert the text in the string to an array of bytes
                TextBytes = System.Text.Encoding.UTF8.GetBytes(SomeText);
                //generate the hash based on the array of bytes
                HashBytes = HashGenerator.ComputeHash(TextBytes);
                //generate the hash string replacing blank characters with -
                HashString = BitConverter.ToString(HashBytes).Replace("-", "");
                return HashString;
            }
            else   //if there is nothing to process
            {
                //return a blank string
                return "";
            }
        }

        public string SignUp(string UserFirstName, string UserLastName, string UserTelephone, string UserEmail, string UserPassword, string PasswordConfirm)
        {
            //var to store error
            String Error = "";
            //check if Email is taken
            if (EmailTaken(UserEmail) == false)
            {
                //check to see if passwords match
                if (UserPassword == PasswordConfirm)
                {
                    //validate the data stored
                    if (Valid(UserFirstName, UserLastName, UserTelephone, UserEmail, UserPassword) == "")
                    {
                        //hash the password
                        string HashPassword = GetHashString(UserPassword + UserEmail);
                        
                        //connect to DB
                        clsDataConnection DB = new clsDataConnection();
                        //add the parameters
                        DB.AddParameter("@UserFirstName", UserFirstName);
                        DB.AddParameter("@UserLastName", UserLastName);
                        DB.AddParameter("@UserTelephone", UserTelephone);
                        DB.AddParameter("@UserEmail", UserEmail);
                        DB.AddParameter("@UserPassword", HashPassword);
                        //executet the stored procedure
                        DB.Execute("sproc_tblUser_Insert");
                    }
                    //if there was an error
                    else
                    {
                        //error msg
                        Error = Valid(UserFirstName, UserLastName, UserTelephone, UserEmail, UserPassword);
                    }
                }
                else
                {
                    Error = Error + "The passwords do not match";
                }
            }
            //error msg
            return Error;
        }

        public string AdminSignUp(string AdminFirstName, string AdminLastName, string AdminTelephone, string AdminEmail, string AdminPassword, string PasswordConfirm)
        {
            //var to store error
            String Error = "";
            //check if Email is taken
            if (AdminEmailTaken(AdminEmail) == false)
            {
                //check to see if passwords match
                if (AdminPassword == PasswordConfirm)
                {
                    //validate the data stored
                    if (ValidAdmin(AdminFirstName, AdminLastName, AdminTelephone, AdminEmail, AdminPassword) == "")
                    {
                        //hash the password
                        string HashPassword = GetHashString(AdminPassword + AdminEmail);
                        //connect to DB
                        clsDataConnection DB = new clsDataConnection();
                        //add the parameters
                        DB.AddParameter("@AdminFirstName", AdminFirstName);
                        DB.AddParameter("@AdminLastName", AdminLastName);
                        DB.AddParameter("@AdminTelephone", AdminTelephone);
                        DB.AddParameter("@AdminEmail", AdminEmail);
                        DB.AddParameter("@AdminPassword", HashPassword);
                        //executet the stored procedure
                        DB.Execute("sproc_tblAdmin_Insert");
                    }
                    //if there was an error
                    else
                    {
                        //error msg
                        Error = ValidAdmin(AdminFirstName, AdminLastName, AdminTelephone, AdminEmail, AdminPassword);
                    }
                }
                else
                {
                    Error = Error + "The passwords do not match";
                }
            }
            //error msg
            return Error;
        }
        public string HealthSpecialistSignUp(string HealthSpecialistFirstName, string HealthSpecialistLastName, string HealthSpecialistTelephone, string HealthSpecialistEmail, string HealthSpecialistPassword, string PasswordConfirm)
        {
            //var to store error
            String Error = "";
            //check if Email is taken
            if (HealthSpecialistEmailTaken(HealthSpecialistEmail) == false)
            {
                //check to see if passwords match
                if (HealthSpecialistPassword == PasswordConfirm)
                {
                    //validate the data stored
                    if (ValidHealthSpecialist(HealthSpecialistFirstName, HealthSpecialistLastName, HealthSpecialistTelephone, HealthSpecialistEmail, HealthSpecialistPassword) == "")
                    {
                        //hash the password
                        string HashPassword = GetHashString(HealthSpecialistPassword + HealthSpecialistEmail);
                        //connect to DB
                        clsDataConnection DB = new clsDataConnection();
                        //add the parameters
                        DB.AddParameter("@HealthSpecialistFirstName", HealthSpecialistFirstName);
                        DB.AddParameter("@HealthSpecialistLastName", HealthSpecialistLastName);
                        DB.AddParameter("@HealthSpecialistTelephone", HealthSpecialistTelephone);
                        DB.AddParameter("@HealthSpecialistEmail", HealthSpecialistEmail);
                        DB.AddParameter("@HealthSpecialistPassword", HashPassword);
                        //executet the stored procedure
                        DB.Execute("sproc_tblHealthSpecialist_Insert");
                    }
                    //if there was an error
                    else
                    {
                        //error msg
                        Error = ValidHealthSpecialist(HealthSpecialistFirstName, HealthSpecialistLastName, HealthSpecialistTelephone, HealthSpecialistEmail, HealthSpecialistPassword);
                    }
                }
                else
                {
                    Error = Error + "The passwords do not match";
                }
            }
            //error msg
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
                Error = Error + "The first name cannot have more than 25 characters ";
            }
            if (HealthSpecialistLastName.Length < 2)
            {
                //return an error message
                Error = "the name may not be blank";
            }
            if (HealthSpecialistLastName.Length > 25)
            {
                //error
                Error = Error + "The last name cannot have more than 25 characters ";
            }
            if (HealthSpecialistTelephone.Length == 0)
            {
                //return an error message
                Error = "the name may not be blank";
            }
            if (HealthSpecialistTelephone.Length > 11)
            {
                //error
                Error = Error + "The Telephone number cannot have more than 11 characters ";
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
                Error = Error + "The password cannot have more than 50 characters ";
            }
            //if the name of the HealthSpecialistis not blank
            //if the password doesnt contain numbers
            if (ContainsNumber(HealthSpecialistPassword) == false)
            {
                //error msg
                Error = Error + "Your password must have numbers in it" + "<br />";
            }
            //Password Valida


            return Error;
        }

        public string ValidAdmin(string AdminFirstName, string AdminLastName, string AdminTelephone, string AdminEmail, string AdminPassword)
        {
            //string variable to store error message
            String Error = "";


            //if the name of the Admini is less than 2
            if (AdminFirstName.Length < 2)
            {
                //return an error message
                Error = "the name must not be less than 2";
            }
            if (AdminFirstName.Length > 25)
            {
                //error
                Error = Error + "The Admin name cannot have more than 25 characters ";
            }
            if (AdminLastName.Length < 2)
            {
                //return an error message
                Error = "the name must not be less than 2";
            }
            if (AdminLastName.Length > 25)
            {
                //error
                Error = Error + "The Admin name cannot have more than 25 characters ";
            }
            if (AdminTelephone.Length == 0)
            {
                //return an error message
                Error = "the telephone must not be blank";
            }
            if (AdminTelephone.Length > 11)
            {
                //error
                Error = Error + "The number  cannot have more than 11 characters ";
            }


            if (AdminEmail.Length < 5)
            {
                //return an error message
                Error = "the email may not be less than 5 characters";
            }
            if (AdminEmail.Length > 50)
            {
                //error
                Error = Error + "The Admin email cannot have more than 50 characters ";
            }

            //Password Validation//////////////////////////////////
            //if password has less than 8 characters
            if (AdminPassword.Length < 8)
            {
                //error msg
                Error = "Password must be at least 8 characters" + "<br />";
            }
            if (AdminPassword.Length > 50)
            {
                Error = "Password must be at least 50 characters" + "<br />";
            }
            //if the password doesnt contain numbers
            if (ContainsNumber(AdminPassword) == false)
            {
                //error msg
                Error = Error + "Your password must have numbers in it" + "<br />";
            }
            //Password Validation//////////////////////////////////


            return Error;
        }

        private string CheckPassword(string AdminPassword)
        {
            //var to store error
            string Error = "";
            //if password has less than 7 characters
            if (AdminPassword.Length < 9)
            {
                //error msg
                Error = "Password must be at least 9 characters" + "<br />";
            }
            //if the password doesnt contain numbers
            if (ContainsNumber(AdminPassword) == false)
            {
                //error msg
                Error = Error + "Your password must have numbers in it" + "<br />";
            }
            return Error;
        }

        public string Valid(string UserFirstName, string UserLastName, string UserTelephone, string UserEmail, string UserPassword)
        {
            //string variable to store error message
            String Error = "";


            //if the name of the user must be above 2 charcters
            if (UserFirstName.Length < 2)
            {
                //return an error message
                Error = "the name must be above 2 charcters";
            }
            if (UserFirstName.Length > 25)
            {
                //error
                Error = Error + "The user name cannot have more than 25 characters ";
            }
            if (UserLastName.Length < 2)
            {
                //return an error message
                Error = "the name must be above 2 charcters";
            }
            if (UserLastName.Length > 25)
            {
                //error
                Error = Error + "The user name cannot have more than 25 characters ";
            }
            if (UserTelephone.Length == 0)
            {
                //return an error message
                Error = "the number may not be blank";
            }
            if (UserTelephone.Length > 11)
            {
                //error
                Error = Error + "The telephone cannot have more than 11 characters ";
            }


            if (UserEmail.Length < 5)
            {
                //return an error message
                Error = "the email may not be less than 5 characters";
            }
            if (UserEmail.Length > 50)
            {
                //error
                Error = Error + "The useremail cannot have more than 50 characters ";
            }

            if (UserPassword.Length < 8)
            {
                //return an error message
                Error = "the Password may not be less than 8 be characters";
            }
            if (UserPassword.Length > 50)
            {
                //error
                Error = Error + "The password cannot have more than 50 characters ";
            }
            //if (ContainsNumber(UserPassword) == false)
            //{
            //    Error = Error + "Your password must have numbers in it" + "<br />";
            //}
            //PASSWORD VALIDATION///////////////////


            return Error;
        }

        private Boolean ContainsNumber(string UserPassword)
        {
            //checks to see if a password contains a number
            //var to indicate found
            Boolean Found = false;
            //counter for loop
            int Counter = 0;
            //used to store a single character
            char AChar;
            //while found is false and char less than 9
            while (Found == false & Counter < 9)
            {
                //set temp to the value of Counter plus 48 to point at the numeric ascii codes
                int Temp = Counter + 48;
                //get the char value of the ascii code
                AChar = (char)Temp;
                //if the code is in the password
                if (UserPassword.Contains(AChar) == true)
                {
                    //set found = true
                    Found = true;
                }
                else
                {
                    //otherwise keep looking
                    Counter += 1;
                }
            }
            //return the state of found
            return Found;
        }

        public Boolean EmailTaken(string UserEmail)
        {
            //tests to see if the email address is taken
            //connect to the database and see if it there already
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@UserEmail", UserEmail);
            DB.Execute("sproc_tblUser_FilterByUserEmail");
            //if one record found then it is already gone
            if (DB.Count == 1)
            {
                //return true
                return true;
            }
            else
            {
                //return false
                return false;
            }
        }

        public Boolean AdminEmailTaken(string AdminEmail)
        {
            //tests to see if the email address is taken
            //connect to the database and see if it there already
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@AdminEmail", AdminEmail);
            DB.Execute("sproc_tblAdmin_FilterByAdminEmail");
            //if one record found then it is already gone
            if (DB.Count == 1)
            {
                //return true
                return true;
            }
            else
            {
                //return false
                return false;
            }
        }

        public Boolean HealthSpecialistEmailTaken(string HealthSpecialistEmail)
        {
            //tests to see if the email address is taken
            //connect to the database and see if it there already
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@HealthSpecialistEmail", HealthSpecialistEmail);
            DB.Execute("sproc_tblHealthSpecialist_FilterByHealthSpecialistEmail");
            //if one record found then it is already gone
            if (DB.Count == 1)
            {
                //return true
                return true;
            }
            else
            {
                //return false
                return false;
            }
        }



    }
}
