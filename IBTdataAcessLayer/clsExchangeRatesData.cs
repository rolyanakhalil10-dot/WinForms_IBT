using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBTdataAcessLayer
{
    public class clsExchangeRatesData
    {
        public static void UpdateRate(string currencyCode, double rate)
        {
            using (SqlConnection conn = new SqlConnection(clsConnectionString.connection))
            {
                string query = "UPDATE Currencies SET Rate = @Rate WHERE Code = @Code";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Rate", rate);
                    cmd.Parameters.AddWithValue("@Code", currencyCode);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
