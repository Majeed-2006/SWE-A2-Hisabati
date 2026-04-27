using System.Data;

namespace DataAccessLayerDAL.Interfaces
{
    public interface ICategoryDataAccess
    {
        DataTable GetAllCategories();
        
        int AddCategory(string categoryName, string categoryIcon);

 
        DataRow GetCategoryByID(int categoryID);
    }
}