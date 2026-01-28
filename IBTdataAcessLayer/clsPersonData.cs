using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBTdataAcessLayer
{
    public class clsPersonData
    {
        public static bool GetPersonByID(int PersonID, ref string FirstName, ref string LastName, ref short Gender,
           ref DateTime DateOfBirth,ref int CountryID, ref string Phone, ref string Email,
            ref string Address, ref string ImagePath)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.connection))
            {
                using (SqlCommand command = new SqlCommand("SP_GetPersonByID", connection))
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
                            FirstName = (string)reader["FirstName"];
                            LastName = (string)reader["LastName"]; 
                            Gender = (byte)reader["Gender"];
                            DateOfBirth = (DateTime)reader["DateOfBirth"];
                            CountryID = (int)reader["CountryID"];
                            if (reader["Phone"] != DBNull.Value)
                            {
                                Phone = (string)reader["Phone"];
                            }
                            else
                            {
                                Phone = "";
                            }

                            if (reader["Email"] != DBNull.Value)
                            {
                                Email = (string)reader["Email"];
                            }
                            else
                            {
                                Email = "";
                            }

                            Address = (string)reader["Address"];
                            if (reader["ImagePath"] != DBNull.Value)
                            {
                                ImagePath = (string)reader["ImagePath"];
                            }
                            else
                            {
                                ImagePath = "";
                            }


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

        public static DataTable GetAllPeople ()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsConnectionString.connection))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAllPeople", connection))
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

        public static bool DeletePersonByID(int PersonID)
        {
            int affectedrows = 0;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.connection))
            {
                using (SqlCommand command = new SqlCommand("SP_DeletePerson", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", PersonID);

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

        public static bool UpdatePersonInfo(
string FirstName, string LastName, short Gender, DateTime DateOfBirth,
int CountryID, string Phone, string Email, string Address,
string ImagePath, int PersonID)
        {
            int affectedRows = -1;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.connection))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdatePersonInfo", connection))
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
                    command.Parameters.AddWithValue("@PersonID", PersonID);




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
