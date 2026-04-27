using System;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayerDAL.Interfaces;

namespace DataAccessLayerDAL
{
   
    public class clsTransactionDAL : ITransactionDataAccess
    {
       
        public int Add(int userID, decimal amount, string type, int categoryID, DateTime date, string note)
        {
            string query = @"INSERT INTO Transactions (UserID, Amount, TransactionType, CategoryID, TransactionDate, Note)
                             VALUES (@UserID, @Amount, @Type, @CategoryID, @Date, @Note);
                             SELECT SCOPE_IDENTITY();";

            SqlParameter[] parameters = {
                new SqlParameter("@UserID", userID),
                new SqlParameter("@Amount", amount),
                new SqlParameter("@Type", type),
                new SqlParameter("@CategoryID", categoryID),
                new SqlParameter("@Date", date),
                new SqlParameter("@Note", (object)note ?? DBNull.Value)
            };

            object result = clsDatabaseHelper.ExecuteScalar(query, parameters);
            return (result != null && int.TryParse(result.ToString(), out int id)) ? id : -1;
        }

        
        public DataTable GetUserTransactions(int userID)
        {
            SqlParameter[] parameters = { new SqlParameter("@UserID", userID) };
            return clsDatabaseHelper.ExecuteQuery("SELECT * FROM Transactions WHERE UserID = @UserID ORDER BY TransactionDate DESC", parameters);
        }
    }
}