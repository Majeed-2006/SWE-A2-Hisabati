using System;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayerDAL.Interfaces; 

namespace DataAccessLayerDAL
{
   
    public class clsBudgetDAL : IBudgetDataAccess
    {
        
        public bool SetBudget(int userID, int categoryID, decimal limitAmount)
        {
            string query = "INSERT INTO Budgets (UserID, CategoryID, Amount) VALUES (@UserID, @CategoryID, @Amount)";

            SqlParameter[] parameters = {
                new SqlParameter("@UserID", userID),
                new SqlParameter("@CategoryID", categoryID),
                new SqlParameter("@Amount", limitAmount)
            };

           
            return clsDatabaseHelper.ExecuteScalar(query, parameters) != null;
        }

        
        public DataTable GetBudgets(int userID)
        {
            SqlParameter[] parameters = { new SqlParameter("@UserID", userID) };
            return clsDatabaseHelper.ExecuteQuery("SELECT * FROM Budgets WHERE UserID = @UserID", parameters);
        }

       
        public static DataTable GetAllBudgets()
        {
            return clsDatabaseHelper.ExecuteQuery("SELECT * FROM Budgets");
        }
    }
}