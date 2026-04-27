using DataAccessLayerDAL;
using DataAccessLayerDAL.Interfaces;

namespace BusinessLayerBL
{
    public class clsUser
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Currency { get; set; }
        public string Username { get; private set; }

        private readonly IUserDataAccess _userDataAccess;

        public clsUser()
        {
            this.UserID = -1;
            this._userDataAccess = new clsUserDAL();
        }

        public bool Save()
        {
            int id = _userDataAccess.AddNewUser(FirstName, LastName, Email, Password, Currency);

            if (id != -1)
            {
                this.UserID = id;
                this.Username = (FirstName + LastName + id.ToString()).ToLower();

                return true;
            }
            return false;
        }

        public static bool Login(string username, string password)
        {
            IUserDataAccess dal = new clsUserDAL();
            return dal.CheckUserCredentials(username, password);
        }
    }
}