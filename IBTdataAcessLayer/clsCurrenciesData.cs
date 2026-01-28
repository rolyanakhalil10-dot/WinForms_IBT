using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBTdataAcessLayer
{
    public class clsCurrenciesData
    {
        public static DataTable GetAllCurrencies()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsConnectionString.connection))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAllCurrencies", connection))
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
                    }
                    catch
                    {
                    }
                }
                return dt;

            }
        }

        public static double ConvertCurrency(double amount, string from, string to)
        {
            double result = 0;

            using (SqlConnection conn = new SqlConnection(clsConnectionString.connection))
            using (SqlCommand cmd = new SqlCommand("SP_ConvertCurrency", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@FromCurrency", from);
                cmd.Parameters.AddWithValue("@ToCurrency", to);

                SqlParameter output = new SqlParameter("@ConvertedAmount", SqlDbType.Float)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(output);

                conn.Open();
                cmd.ExecuteNonQuery();
                result = (double)output.Value;
            }

            return result;
        }

        public static DataTable GetAllCurrencyCodes()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsConnectionString.connection))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAllCurrencyCodes", connection))
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
                    }
                    catch
                    {
                    }
                }
                return dt;

            }
        }


    }
}
