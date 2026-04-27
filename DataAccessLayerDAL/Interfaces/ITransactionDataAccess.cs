using System.Data;


namespace DataAccessLayerDAL.Interfaces
{
    public interface ITransactionDataAccess
    {

        int Add(int userID, decimal amount, string type, int categoryID, DateTime date, string note);


        DataTable GetUserTransactions(int userID);
    }
}