using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerDAL.Interfaces
{
    public interface IUserDataAccess
    {
        bool CheckUserCredentials(string username, string password);
        
        int AddNewUser(string firstName, string lastName, string email, string password, string currency);

     

    }
}
