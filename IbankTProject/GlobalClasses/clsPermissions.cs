using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IBTpresentationLayer.frmPermissions;

namespace IBTpresentationLayer
{
    public class clsPermissions
    {
        public enum enPermissions
        {
            eAll = -1, pManageClients = 1, pTransactions = 2, pManageUsers = 4,
            pCurrency = 8, pManagePermissions = 16, pAccountSettings = 32
        };
        public enPermissions UserPermissions { get; set; }

        public bool _CheckAccessPermission(int permission)
        {
            if ((enPermissions)permission == enPermissions.eAll)
                return true;

            if ((this.UserPermissions & (enPermissions)permission) == (enPermissions)permission)
                return true;
            else
                return false;
        }

    }
}
