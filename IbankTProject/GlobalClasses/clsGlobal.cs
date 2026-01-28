using IBTbusinessLogicLayer;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBTpresentationLayer
{
    public class clsGlobal
    {
        public static clsUsers CurrentUser;

        public static bool RememberUsernameAndPassword(string Username, string Password)
        {

            string subKey = @"SOFTWARE\IbankT_MyWin_App";
            string valueNameUserName = "IbankT_LoginUserName";
            string ValueNamePassword = "IbankT_LoginPassword";
            try
            {
                using (RegistryKey Key = Registry.CurrentUser.CreateSubKey(subKey))
                {
                    if (Key == null)
                    {
                        return false;
                    }
                    Key.SetValue(valueNameUserName, Username, RegistryValueKind.String);
                    Key.SetValue(ValueNamePassword, Password, RegistryValueKind.String);

                }

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public static bool GetStoredCredential(ref string Username, ref string Password)
        {
            string subKey = @"SOFTWARE\IbankT_MyWin_App";
            try
            {
                using (RegistryKey Key = Registry.CurrentUser.OpenSubKey(subKey))
                {
                    if (Key == null)
                    {
                        return false;
                    }

                    Username = Key.GetValue("IbankT_LoginUserName") as string;
                    Password = Key.GetValue("IbankT_LoginPassword") as string;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;

        }

    }
}
