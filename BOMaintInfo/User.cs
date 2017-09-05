using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class User
    {
        //======================================================================================================================================
        //Attribut
        private int id;
        private string username;
        private string password;

        public string Password { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }
        public int Id { get => id; set => id = value; }
    }
}
