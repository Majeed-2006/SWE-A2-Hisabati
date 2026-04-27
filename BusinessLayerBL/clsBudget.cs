using System;
using System.Data;
using DataAccessLayerDAL;          
using DataAccessLayerDAL.Interfaces;

namespace BusinessLayerBL
{
    public class clsBudget
    {
       
        private readonly IBudgetDataAccess _budgetData;

        
        public clsBudget()
        {
            
            this._budgetData = new clsBudgetDAL();
        }

        
        public clsBudget(IBudgetDataAccess budgetDataAccess)
        {
            this._budgetData = budgetDataAccess;
        }

       
        public bool SetMyBudget(int userId, decimal limit)
        {
            return _budgetData.SetBudget(userId, 0, limit);
        }
    }
}