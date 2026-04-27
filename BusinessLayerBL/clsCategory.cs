using System;
using System.Data;
using DataAccessLayerDAL;
using DataAccessLayerDAL.Interfaces;

namespace BusinessLayerBL
{
    public class clsCategory
    {
        private readonly ICategoryDataAccess _categoryData;

        public clsCategory()
        { 
            _categoryData = new clsCategoryDAL();
        }

        public static DataTable GetAll()
        {
            ICategoryDataAccess dal = new clsCategoryDAL();
            return dal.GetAllCategories();
        }
    }
}