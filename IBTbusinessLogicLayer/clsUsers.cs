using IBTdataAcessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static IBTbusinessLogicLayer.clsPerson;

namespace IBTbusinessLogicLayer
{
    public class clsUsers : clsPerson
    {
        public int UserID { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public int AccessLevel { set; get; }


        private clsUsers(int PersonID, string FirstName, string LastName, short Gender, DateTime DateOfBirth,
            int CountryID, string Phone, string Email, string Address, string ImagePath,
            int UserID, string UserName, string Password, int AccessLevel) : base(PersonID, FirstName, LastName, Gender, DateOfBirth,
            CountryID, Phone, Email, Address, ImagePath)
        {
            this.UserID = UserID;
            this.UserName = UserName;
            this.Password = Password;
            this.AccessLevel = AccessLevel;
            Mode = enMode.Update;
        }

        public clsUsers()
        {
            this.UserID = -1;
            this.UserName = "";
            this.Password = "";
            this.AccessLevel = 0;
            Mode = enMode.AddNew;
        }


        private clsUsers(int UserID, int PersonID, string Username, string Password,
    int AccessLevel)

        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = Username;
            this.Password = Password;
            this.AccessLevel = AccessLevel;

            Mode = enMode.Update;
        }


        public static DataTable GetAllUsers()
        {
            return clsUsersData.GetAllUsers();
        }

        public static clsUsers GetUserByNameandPassword(string UserName, string Password)
        {
            int UserID = -1; int PersonID = -1; int AccessLevel = 0;

            string HashedPassword = clsHashPassword.ComputeHash(Password);
            bool isFound = clsUsersData.GetUserByNameandPassword(UserName, HashedPassword,ref PersonID,ref UserID, ref AccessLevel);
            if (isFound)
            {
                return new clsUsers(UserID, PersonID, UserName, HashedPassword, AccessLevel);
            }
            else
            {
                return null;
            }

        }


        public static bool DeleteUser(int UserID)
        {
            return clsUsersData.DeleteUserByID(UserID);
        }

        private bool _AddNewUser()
        {
            int personID = -1;
            string HashedPassword = clsHashPassword.ComputeHash(this.Password);

            int UserID = clsUsersData.AddNewUser(
                this.FirstName, this.LastName, this.Gender, this.DateOfBirth,
                this.CountryID, this.Phone, this.Email, this.Address,
                this.ImagePath, ref personID, this.UserName, HashedPassword, this.AccessLevel);

            if (UserID != -1)
            {
                this.PersonID = personID;
                this.UserID = UserID;
                return true;
            }
            else
            {
                return false;
            }

        }

        private bool _UpdateUser()
        {
            string HashedPassword = clsHashPassword.ComputeHash(Password);

            return clsUsersData.UpdateUserInfo(this.FirstName, this.LastName, this.Gender,
                this.DateOfBirth, this.CountryID, this.Phone, this.Email, this.Address, this.ImagePath,
                this.PersonID, this.UserName, HashedPassword, this.UserID);
        }
        public static clsUsers Find(int UserID)
        {
            int PersonID = -1;
            string FirstName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now.AddYears(-18);
            int CountryID = -1;
            short Gender = 0;
            string UserName = "";
            string Password ="";
            int AccessLevel = 0;

            bool isFound = clsUsersData.GetUserByID(UserID, ref PersonID, ref FirstName, ref LastName,
                ref Gender, ref DateOfBirth, ref CountryID, ref Phone, ref Email, ref Address,
                ref ImagePath, ref UserName, ref Password, ref AccessLevel);

            if (isFound)
            {
                return new clsUsers( PersonID, FirstName, LastName, Gender, DateOfBirth, CountryID,
                    Phone, Email, Address, ImagePath,UserID, UserName, Password,AccessLevel);
            }
            else
            {
                return null;
            }
        }

        public static clsUsers FindByPersonID(int PersonID)
        {
            int UserID = -1;
            string FirstName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now.AddYears(-18);
            int CountryID = -1;
            short Gender = 0;
            string UserName = "";
            string Password = "";
            int AccessLevel = 0;

            bool isFound = clsUsersData.GetUserByPersonID(ref UserID, PersonID, ref FirstName, ref LastName,
                ref Gender, ref DateOfBirth, ref CountryID, ref Phone, ref Email, ref Address,
                ref ImagePath, ref UserName, ref Password, ref AccessLevel);

            if (isFound)
            {
                return new clsUsers(PersonID, FirstName, LastName, Gender, DateOfBirth, CountryID,
                    Phone, Email, Address, ImagePath, UserID, UserName, Password, AccessLevel);
            }
            else
            {
                return null;
            }
        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }

        public static bool DoesUserExistByPersonID(int personID)
        {
            return clsUsersData.CheckUserExistsByPersonID(personID);
        }

        public static bool UpdateUserPermissions(int UserID, int Permissions)
        {
            return clsUsersData.UpdateUserPermissions(UserID, Permissions);
        }

        public static bool REsetPassword(string Email, string NewPasswordHash)
        {
            return clsUsersData.ResetPassword(Email, NewPasswordHash);
        }

    }
}
