using IBTdataAcessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBTbusinessLogicLayer
{
    public class clsUserLogins
    {
        public static bool SaveLoginHistory(int userID, DateTime loginDateTime)
        {
            return clsUserLoginsData.SaveLoginHistory(userID, loginDateTime);
        }
        public static DataTable GetAllLoginHistory()
        {
            return clsUserLoginsData.GetAllLoginDetails();
        }
    }
}
