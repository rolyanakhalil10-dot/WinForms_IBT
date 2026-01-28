using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace IBTbusinessLogicLayer
{
    public class clsResetCodeManager
    {
        private static Dictionary<string, (string Code, DateTime Expiry)> _codes =
            new Dictionary<string, (string, DateTime)>();

        public static string GenerateAndStoreCode(string email)
        {
            string code = new Random().Next(100000, 999999).ToString();
            _codes[email] = (code, DateTime.Now.AddMinutes(10));
            return code;
        }

        public static bool ValidateCode(string email, string code)
        {
            if (_codes.ContainsKey(email))
            {
                var (storedCode, expiry) = _codes[email];
                if (storedCode == code && DateTime.Now <= expiry)
                {
                    _codes.Remove(email);
                    return true;
                }
            }
            return false;
        }
    }
}
