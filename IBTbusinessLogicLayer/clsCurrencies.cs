using IBTdataAcessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IBTbusinessLogicLayer
{
    public class clsCurrencies
    {
        public static DataTable GetAllCurrencies()
        {
            return clsCurrenciesData.GetAllCurrencies();
        }

        public static double ExchangeMoney(double amount, string from, string to)
        {
            return clsCurrenciesData.ConvertCurrency(amount, from, to);
        }

        public static DataTable GetAllCurrencyCodes()
        {
            return clsCurrenciesData.GetAllCurrencyCodes();
        }

    }
}
