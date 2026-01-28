using IBTdataAcessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IBTbusinessLogicLayer
{
    public class clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        public int PersonID { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string FullName
        {
            get { return FirstName + " " + LastName; }

        }
        public short Gender { set; get; }
        public DateTime DateOfBirth { set; get; }
        public int CountryID { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public string Address { set; get; }

        private string _ImagePath;

        public string ImagePath
        {
            get { return _ImagePath; }
            set { _ImagePath = value; }
        }

        public clsCountries CountryInfo;

        public clsPerson(int PersonID, string FirstName, string LastName, short Gender, DateTime DateOfBirth,
            int CountryID, string Phone, string Email, string Address, string ImagePath)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Gender = Gender;
            this.DateOfBirth = DateOfBirth;
            this.CountryID = CountryID;
            this.Phone = Phone;
            this.Email = Email;
            this.Address = Address;
            this.ImagePath = ImagePath;
            this.CountryInfo = clsCountries.Find(CountryID);
            Mode = enMode.Update;
        }

        public clsPerson()
        {
            this.PersonID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Gender = 0;
            this.DateOfBirth = DateTime.Now.AddYears(-18);
            this.CountryID = -1;
            this.Phone = "";
            this.Email = "";
            this.Address = "";
            this.ImagePath = "";
            Mode = enMode.AddNew;
        }

        public static clsPerson Find(int PersonID)
        {
            string FirstName = "",  LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now.AddYears(-18);
            int CountryID = -1;
            short Gender = 0;

            bool isFound = clsPersonData.GetPersonByID(PersonID, ref FirstName, ref LastName, ref Gender,
            ref DateOfBirth, ref CountryID, ref Phone, ref Email,
            ref Address, ref ImagePath);

            if (isFound)
            {
                return new clsPerson(PersonID, FirstName, LastName, Gender,
             DateOfBirth, CountryID, Phone, Email,
             Address, ImagePath);
            }
            else
            {
                return null;
            }

        }
        
        public bool _UpdatePerosn()
        {
            return clsPersonData.UpdatePersonInfo(
     this.FirstName, this.LastName, this.Gender, this.DateOfBirth,
this.CountryID, this.Phone, this.Email, this.Address,
this.ImagePath, this.PersonID);

        }

        public static DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();
        }

        public static bool DeleteClientByID(int ClientID)
        {
            return ClientsData.DeleteClientByID(ClientID);
        }

        public static bool UpdatePinCode(int ClientID, string PinCode)
        {
            return ClientsData.UpdatePinCode(ClientID, PinCode);
        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    //if (_AddNewClient())
                    //{
                    //    Mode = enMode.Update;
                    //    return true;
                    //}
                    //else
                    //    return false;

                case enMode.Update:
                    return _UpdatePerosn();
            }
            return false;
        }

    }
}
