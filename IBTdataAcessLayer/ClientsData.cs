using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBTdataAcessLayer
{
    public class ClientsData
    {

        public static DataTable GetAllClient()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsConnectionString.connection))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAllClients", connection))
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

        public static bool DeleteClientByID(int ClientID)
        {
            int affectedrows = 0;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.connection))
            {
                using (SqlCommand command = new SqlCommand("SP_DeleteClient", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ClientID", ClientID);

                    try
                    {
                        connection.Open();
                        affectedrows = command.ExecuteNonQuery();

                    }
                    catch
                    {
                        return false;
                    }
                }
            }
            return affectedrows > 0;

        }

        public static bool UpdatePinCode(int ClientID, string PinCode)
        {
            int affectedrows = 0;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.connection))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdateClientPinCode", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@InsertedClientID", ClientID);
                    command.Parameters.AddWithValue("@PinCode", PinCode);

                    try
                    {
                        connection.Open();
                        affectedrows = command.ExecuteNonQuery();

                    }
                    catch
                    {
                        return false;
                    }
                }
            }
            return affectedrows > 0;
        }
        
        public static bool GetClientByID(int ClientID, ref int PersonID, ref string FirstName, ref string LastName,
    ref short Gender, ref DateTime DateOfBirth, ref int CountryID, ref string Phone, ref string Email,
    ref string Address, ref string PinCode, ref decimal Balance, ref string ImagePath)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.connection))
            {
                using (SqlCommand command = new SqlCommand("SP_GetClientByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ClientID", ClientID);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            isFound = true;

                            PersonID = (int)reader["PersonID"];
                            FirstName = (string)reader["FirstName"];
                            LastName = (string)reader["LastName"];
                            Gender = Convert.ToInt16(reader["Gender"]);
                            DateOfBirth = (DateTime)reader["DateOfBirth"];
                            CountryID = (int)reader["CountryID"];
                            Phone = reader["Phone"] != DBNull.Value ? (string)reader["Phone"] : "";
                            Email = reader["Email"] != DBNull.Value ? (string)reader["Email"] : "";
                            Address = (string)reader["Address"];
                            PinCode = (string)reader["PinCode"];
                            Balance = Convert.ToDecimal(reader["Balance"]);
                            ImagePath = reader["ImagePath"] != DBNull.Value ? (string)reader["ImagePath"] : "";
                        }
                        else
                        {
                            isFound = false;
                        }
                    }
                    catch
                    {
                    }
                }
                return isFound;

            }

        }

        public static int AddNewClient(
            string FirstName, string LastName, short Gender, DateTime DateOfBirth,
            int CountryID, string Phone, string Email, string Address,
            string ImagePath, string PinCode, decimal Balance,
            ref int PersonID)
        {
            int ClientID = -1;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.connection))
            {
                using (SqlCommand command = new SqlCommand("SP_AddNewClient", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@CountryID", CountryID);
                    command.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(Email) ? (object)DBNull.Value : Email);
                    command.Parameters.AddWithValue("@ImagePath", string.IsNullOrEmpty(ImagePath) ? (object)DBNull.Value : ImagePath);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@Phone", string.IsNullOrEmpty(Phone) ? (object)DBNull.Value : Phone);
                    command.Parameters.AddWithValue("@PinCode", PinCode);
                    command.Parameters.AddWithValue("@Balance", 0);


                    SqlParameter personIdParam = new SqlParameter("@PersonID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(personIdParam);

                    SqlParameter clientIdParam = new SqlParameter("@ClientID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(clientIdParam);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        if (personIdParam.Value != DBNull.Value)
                            PersonID = Convert.ToInt32(personIdParam.Value);

                        if (clientIdParam.Value != DBNull.Value)
                            ClientID = Convert.ToInt32(clientIdParam.Value);
                    }
                    catch
                    {
                        return -1;
                    }
                }
            }

            return ClientID;
        }

        public static bool UpdateClientInfo(
    string FirstName, string LastName, short Gender, DateTime DateOfBirth,
    int CountryID, string Phone, string Email, string Address,
    string ImagePath, string PinCode, int ClientID, int PersonID)
        {
            int affectedRows = -1;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.connection))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdateClientInfo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@CountryID", CountryID);
                    command.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(Email) ? (object)DBNull.Value : Email);
                    command.Parameters.AddWithValue("@ImagePath", string.IsNullOrEmpty(ImagePath) ? (object)DBNull.Value : ImagePath); 
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@Phone", string.IsNullOrEmpty(Phone) ? (object)DBNull.Value: Phone);
                    command.Parameters.AddWithValue("@PinCode", PinCode);
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@ClientID", ClientID);




                    try
                    {
                        connection.Open();
                        affectedRows = command.ExecuteNonQuery();

                    }
                    catch
                    {
                        return false;
                    }
                }
            }

            return affectedRows > 0;
        }


        public static bool GetClientByPersonID(ref int ClientID,  int PersonID, ref string FirstName, ref string LastName,
ref short Gender, ref DateTime DateOfBirth, ref int CountryID, ref string Phone, ref string Email,
ref string Address, ref string PinCode, ref decimal Balance, ref string ImagePath)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.connection))
            {
                using (SqlCommand command = new SqlCommand("SP_GetClientByPersonID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            isFound = true;

                            ClientID = (int)reader["ClientID"];
                            FirstName = (string)reader["FirstName"];
                            LastName = (string)reader["LastName"];
                            Gender = Convert.ToInt16(reader["Gender"]);
                            DateOfBirth = (DateTime)reader["DateOfBirth"];
                            CountryID = (int)reader["CountryID"];
                            Phone = reader["Phone"] != DBNull.Value ? (string)reader["Phone"] : "";
                            Email = reader["Email"] != DBNull.Value ? (string)reader["Email"] : "";
                            Address = (string)reader["Address"];
                            PinCode = (string)reader["PinCode"];
                            Balance = Convert.ToDecimal(reader["Balance"]);
                            ImagePath = reader["ImagePath"] != DBNull.Value ? (string)reader["ImagePath"] : "";
                        }
                        else
                        {
                            isFound = false;
                        }
                    }
                    catch
                    {
                    }
                }
                return isFound;

            }

        }



    }
}
