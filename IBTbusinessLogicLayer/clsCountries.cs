using IBTdataAcessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBTbusinessLogicLayer
{
    public class clsCountries
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        private clsCountries(int CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
        }
        public static clsCountries Find(int CountryID)
        {
            string CountryName = "";
            bool isFound = clsCountreisData.GetCountryByID(CountryID, ref CountryName);
            if (isFound)
            {
                return new clsCountries(CountryID, CountryName);
            }
            else
            {
                return null;
            }
        }
        public static clsCountries Find(string CountryName)
        {
            int CountryID = -1;
            bool isFound = clsCountreisData.GetCountryByName(ref CountryID, CountryName);
            if (isFound)
            {
                return new clsCountries(CountryID, CountryName);
            }
            else
            {
                return null;
            }
        }
        public static DataTable GetAllCountries()
        {
            return clsCountreisData.GetAllCountries();
        }

    }
}
