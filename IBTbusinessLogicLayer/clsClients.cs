using IBTdataAcessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace IBTbusinessLogicLayer
{
    public class clsClients : clsPerson
    {
        public int ClientID { set; get; }
        public string PinCode { set; get; }
        public decimal Balance { set; get; }

        private clsClients(int PersonID, string FirstName, string LastName, short Gender, DateTime DateOfBirth,
            int CountryID, string Phone, string Email, string Address,int ClientID, string PinCode,
            decimal Balance, string ImagePath): base(PersonID, FirstName, LastName, Gender, DateOfBirth,
            CountryID, Phone, Email, Address, ImagePath)
        {
            this.ClientID = ClientID;
            this.PinCode = PinCode;
            this.Balance = Balance;
            Mode = enMode.Update;
        }

        public clsClients()
        {
            this.ClientID = -1;
            this.PinCode = "";
            this.Balance = -1;
            Mode = enMode.AddNew;
        }

        public static clsClients Find(int ClientID)
        {
            int PersonID = -1;
            string FirstName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now.AddYears(-18);
            int CountryID = -1;
            short Gender = 0;
            string PinCode = "";
            decimal Balance = 0;

            bool isFound = ClientsData.GetClientByID(ClientID, ref PersonID, ref FirstName, ref LastName,
                ref Gender, ref DateOfBirth, ref CountryID, ref Phone, ref Email, ref Address,
                ref PinCode, ref Balance, ref ImagePath);

            if (isFound)
            {
                return new clsClients(PersonID, FirstName, LastName, Gender, DateOfBirth, CountryID,
                    Phone, Email, Address, ClientID, PinCode, Balance, ImagePath);
            }
            else
            {
                return null;
            }
        }

        public static clsClients FindByPersonID(int PersonID)
        {
            int ClientID = -1;
            string FirstName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now.AddYears(-18);
            int CountryID = -1;
            short Gender = 0;
            string PinCode = "";
            decimal Balance = 0;

            bool isFound = ClientsData.GetClientByPersonID(ref ClientID, PersonID, ref FirstName, ref LastName,
                ref Gender, ref DateOfBirth, ref CountryID, ref Phone, ref Email, ref Address,
                ref PinCode, ref Balance, ref ImagePath);

            if (isFound)
            {
                return new clsClients(PersonID, FirstName, LastName, Gender, DateOfBirth, CountryID,
                    Phone, Email, Address, ClientID, PinCode, Balance, ImagePath);
            }
            else
            {
                return null;
            }
        }


        public static DataTable GetAllClients()
        {
            return ClientsData.GetAllClient();
        }

        public static bool DeleteClientByID(int ClientID)
        {
            return ClientsData.DeleteClientByID(ClientID);
        }

        public static bool UpdatePinCode(int ClientID, string PinCode)
        {
            return ClientsData.UpdatePinCode(ClientID, PinCode);
        }
        private bool _AddNewClient()
        {
            int personID = -1;

            int clientID = ClientsData.AddNewClient(
                this.FirstName, this.LastName, this.Gender, this.DateOfBirth,
                this.CountryID, this.Phone, this.Email, this.Address,
                this.ImagePath, this.PinCode, this.Balance,
                ref personID);

            if (clientID != -1)
            {
                this.PersonID = personID;
                this.ClientID = clientID;
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool _UpdateClient()
        {
            return ClientsData.UpdateClientInfo(
                 this.FirstName, this.LastName, this.Gender, this.DateOfBirth,
     this.CountryID, this.Phone, this.Email, this.Address,
    this.ImagePath, this.PinCode, this.ClientID, this.PersonID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewClient())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateClient();
            }
            return false;
        }

    }
}
