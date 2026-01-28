using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBTdataAcessLayer
{
    public class clsTransactionsData
    {
        public static bool DepositByPersonID(int personID, decimal amount)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnectionString.connection))
                {
                    using (SqlCommand command = new SqlCommand("SP_DepositByPersonID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID", personID);
                        command.Parameters.AddWithValue("@Amount", amount);

                        connection.Open();
                        int affectedRows = command.ExecuteNonQuery();

                        return affectedRows > 0;
                    }
                }
            }
            catch 
            {
                return false;
            }
        }
        public static bool WithdrawByPersonID(int personID, decimal amount)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnectionString.connection))
                {
                    using (SqlCommand command = new SqlCommand("SP_WithdrawByPersonID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID", personID);
                        command.Parameters.AddWithValue("@Amount", amount);

                        connection.Open();
                        int affectedRows = command.ExecuteNonQuery();

                        return affectedRows > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
        public static bool TransferByPersonID(int senderPersonID, int receiverPersonID, decimal amount)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnectionString.connection))
                {
                    using (SqlCommand command = new SqlCommand("SP_TransferByPersonID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@SenderPersonID", senderPersonID);
                        command.Parameters.AddWithValue("@ReceiverPersonID", receiverPersonID);
                        command.Parameters.AddWithValue("@Amount", amount);

                        connection.Open();
                        int affectedRows = command.ExecuteNonQuery();

                        return affectedRows > 0;
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public static bool AddTransferLog(int sourceAccountID, int destinationAccountID, decimal amount,
            decimal sourceBalance, decimal destinationBalance, int UserID)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionString.connection))
            {
                using (SqlCommand command = new SqlCommand("SP_AddTransferLog", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@SourceAccountID", sourceAccountID);
                    command.Parameters.AddWithValue("@DestinationAccountID", destinationAccountID);
                    command.Parameters.AddWithValue("@Amount", amount);
                    command.Parameters.AddWithValue("@SourceBalance", sourceBalance);
                    command.Parameters.AddWithValue("@DestinationBalance", destinationBalance);
                    command.Parameters.AddWithValue("@UserID", UserID);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }
        }

        public static DataTable GetAllTransferLogs()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsConnectionString.connection))
            {
                using (SqlCommand command = new SqlCommand("SP_GetTransferLogs", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }

            return dt;
        }

        public static DataTable GetTotalBalances()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsConnectionString.connection))
            {
                using (SqlCommand command = new SqlCommand("SP_GetTotalBalances", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }

            return dt;
        }

        public static decimal CalcTotalBalances()
        {
            decimal total = 0;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.connection))
            {
                using (SqlCommand command = new SqlCommand("SP_CalcTotalBalances", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                        total = Convert.ToDecimal(result);
                }
            }

            return total;
        }


    }
}
