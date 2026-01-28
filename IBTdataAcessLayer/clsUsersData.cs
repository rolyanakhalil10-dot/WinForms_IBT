using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Security.Policy;

namespace IBTdataAcessLayer
{
    public class clsUsersData
    {
        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsConnectionString.connection))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAllUsers", connection))
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

        public static bool DeleteUserByID(int UserID)
        {
            int affectedrows = 0;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.connection))
            {
                using (SqlCommand command = new SqlCommand("SP_DeleteUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", UserID);

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

        public static int AddNewUser(
    string FirstName, string LastName, short Gender, DateTime DateOfBirth,
    int CountryID, string Phone, string Email, string Address,
    string ImagePath,
    ref int PersonID,  string UserName, string Password, int AccessLevel)
        {
            int UserID = -1;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.connection))
            {
                using (SqlCommand command = new SqlCommand("SP_AddNewUser", connection))
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
                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@AccessLevel", 0);


                    SqlParameter personIdParam = new SqlParameter("@PersonID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(personIdParam);

                    SqlParameter UserIdParam = new SqlParameter("@UserID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(UserIdParam);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        if (personIdParam.Value != DBNull.Value)
                            PersonID = Convert.ToInt32(personIdParam.Value);

                        if (UserIdParam.Value != DBNull.Value)
                            UserID = Convert.ToInt32(UserIdParam.Value);
                    }
                      catch
                    {
                        return -1;
                    }
                }
            }

            return UserID;
        }


        public static bool GetUserByID(int UserID, ref int PersonID, ref string FirstName, ref string LastName,
ref short Gender, ref DateTime DateOfBirth, ref int CountryID, ref string Phone, ref string Email,
ref string Address, ref string ImagePath, ref string UserName, ref string Password, ref int AccessLevel)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.connection))
            {
                using (SqlCommand command = new SqlCommand("SP_GetUserByUserID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", UserID);

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
                            ImagePath = reader["ImagePath"] != DBNull.Value ? (string)reader["ImagePath"] : "";
                            UserName = (string)reader["UserName"];
                            Password = (string)reader["Password"];
                            AccessLevel = (int)reader["AccessLevel"];

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

        public static bool UpdateUserInfo(
string FirstName, string LastName, short Gender, DateTime DateOfBirth,
    int CountryID, string Phone, string Email, string Address,
    string ImagePath,
     int PersonID, string UserName, string Password, int UserID)
        {
            int affectedRows = -1;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.connection))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdateUserInfo", connection))
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
                    command.Parameters.AddWithValue("@UserName", UserName);
                    //command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@UserID",UserID );
                    command.Parameters.AddWithValue("@Password", Password);




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

        public static bool CheckUserExistsByPersonID(int personID)
        {
            bool exists = false;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.connection))
            {
                using (SqlCommand command = new SqlCommand("SP_CheckUserExistsByPersonID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", personID);

                    SqlParameter existsParam = new SqlParameter("@Exists", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(existsParam);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        exists = Convert.ToBoolean(existsParam.Value);
                    }
                    catch
                    {
                        return false;
                    }
                }
            }

            return exists;
        }

        public static bool UpdateUserPermissions(int PersonID, int AccessLevel)
        {
            int affectedRows = -1;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.connection))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdateUserPermisions", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@AccessLevel", AccessLevel);
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

        public static bool GetUserByNameandPassword(string UserName, string Password, ref int PersonID,
            ref int UserID, ref int AccessLevel)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.connection))
            {
                using (SqlCommand command = new SqlCommand("SP_GetUserByNameAndPassword", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@Password", Password);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            isFound = true;
                            PersonID = (int)reader["PersonID"];
                            UserID = (int)reader["UserID"];
                            AccessLevel = (int)reader["AccessLevel"];
                            UserName = (string)reader["UserName"];
                            Password = (string)reader["Password"];
                        }
                    }
                    catch
                    {
                        return isFound;
                    }
                }
                return isFound;
            }
        }


        public static bool GetUserByPersonID(ref int UserID,  int PersonID, ref string FirstName, ref string LastName,
ref short Gender, ref DateTime DateOfBirth, ref int CountryID, ref string Phone, ref string Email,
ref string Address, ref string ImagePath, ref string UserName, ref string Password, ref int AccessLevel)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.connection))
            {
                using (SqlCommand command = new SqlCommand("SP_GetUserByPersonID", connection))
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
                            UserID = (int)reader["UserID"];
                            FirstName = (string)reader["FirstName"];
                            LastName = (string)reader["LastName"];
                            Gender = Convert.ToInt16(reader["Gender"]);
                            DateOfBirth = (DateTime)reader["DateOfBirth"];
                            CountryID = (int)reader["CountryID"];
                            Phone = reader["Phone"] != DBNull.Value ? (string)reader["Phone"] : "";
                            Email = reader["Email"] != DBNull.Value ? (string)reader["Email"] : "";
                            Address = (string)reader["Address"];
                            ImagePath = reader["ImagePath"] != DBNull.Value ? (string)reader["ImagePath"] : "";
                            UserName = (string)reader["UserName"];
                            Password = (string)reader["Password"];
                            AccessLevel = (int)reader["AccessLevel"];

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

        public static bool ResetPassword(string Email, string NewPasswordHash)
        {
            int affectedRows = -1;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.connection))
            {
                using (SqlCommand command = new SqlCommand("SP_ResetPassword", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@NewPasswordHash", NewPasswordHash);

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


    }
}
