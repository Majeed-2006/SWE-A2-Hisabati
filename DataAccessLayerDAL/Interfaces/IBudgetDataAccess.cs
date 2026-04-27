using System.Data;

namespace DataAccessLayerDAL.Interfaces
{
    public interface IBudgetDataAccess
    {
        bool SetBudget(int userID, int categoryID, decimal limitAmount);

        DataTable GetBudgets(int userID);
    }
}