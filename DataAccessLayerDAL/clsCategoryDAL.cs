using System.Data;
using DataAccessLayerDAL.Interfaces;

namespace DataAccessLayerDAL
{
    
    public class clsCategoryDAL : ICategoryDataAccess
    {
        public DataTable GetAllCategories()
        {
            return clsDatabaseHelper.ExecuteQuery("SELECT * FROM Categories");
        }

        public int AddCategory(string categoryName, string categoryIcon)
        {
           
            return 0;
        }

        public DataRow GetCategoryByID(int categoryID)
        {
           
            return null;
        }
    }
}