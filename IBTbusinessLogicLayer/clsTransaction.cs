using IBTdataAcessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBTbusinessLogicLayer
{
    public class clsTransaction
    {
        public static bool DepositByPersonID(int personID, decimal amount)
        {
            return clsTransactionsData.DepositByPersonID(personID, amount);
        }

        public static bool WithdrawByPersonID(int personID, decimal amount)
        {
            return clsTransactionsData.WithdrawByPersonID(personID, amount);
        }

        public static bool Transfer(int senderPersonID, int receiverPersonID, decimal amount)
        {
            return clsTransactionsData.TransferByPersonID(senderPersonID, receiverPersonID, amount);
        }
        public static bool SaveTransferLog(int sourceID, int destinationID, decimal amount, 
            decimal sourceBalance, decimal destinationBalance, int UserID)
        {
            return clsTransactionsData.AddTransferLog(sourceID, destinationID, amount, sourceBalance, 
                destinationBalance, UserID);
        }

        public static DataTable GetAllTransferLogs()
        {
            return clsTransactionsData.GetAllTransferLogs();
        }
        public static DataTable GetAllTotalBalnces()
        {
            return clsTransactionsData.GetTotalBalances();
        }

        public static decimal CalcTotalBalances()
        {
            return clsTransactionsData.CalcTotalBalances();
        }

    }
}
