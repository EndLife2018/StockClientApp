using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class LoginManager
    {
        private DAO.DAOUser daoUser = new DAO.DAOUser();

        public bool Connect(string username, string password)
        {
            User user = daoUser.getUser(username, password);
            if (user != null)
                return true;
            else
                return false;
        }

    }
}
