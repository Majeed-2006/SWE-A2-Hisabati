using DataAccessLayerDAL.Interfaces;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerDAL
{
    public class clsUserDAL : IUserDataAccess
    {
      
        public  bool CheckUserCredentials(string inputUsername, string password)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"SELECT 1 FROM Users 
                                     WHERE (FirstName + LastName + CAST(UserID AS VARCHAR)) = @InputUser 
                                     AND Password = @Pass";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@InputUser", inputUsername);
                    cmd.Parameters.AddWithValue("@Pass", password);

                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null) isFound = true;
                }
            }
            catch (Exception ex) { /* Log error here */ }
            return isFound;
        }

       
        public  int AddNewUser(string firstName, string lastName, string email, string password, string currency)
        {
            int newUserID = -1;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"INSERT INTO Users (FirstName, LastName, Email, Password, Currency, CreatedDate)
                                 VALUES (@FirstName, @LastName, @Email, @Password, @Currency, GETDATE());
                                 SELECT SCOPE_IDENTITY();";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Currency", currency);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        newUserID = insertedID;
                    }
                }
                catch { }
            }
            return newUserID;
        }
    }
}