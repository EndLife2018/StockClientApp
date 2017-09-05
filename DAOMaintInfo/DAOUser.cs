using BO;
using DAO;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAOUser
    {
        public User getUser(string username, string password)
        {
            using (DbConnection db = DAOConnection.GetConnexion())
            {
                using (DbCommand cde = db.CreateCommand())
                {
                    cde.CommandText = "SELECT * from dbo.auth where username = '"+ username +"' and password = '" + password + "'";

                    User user = new User();
                    try
                    {
                        using (DbDataReader reader = cde.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                user.Id = reader.GetInt32(0);
                                user.Username = reader.GetString(1);
                                user.Password = reader.GetString(2);

                            }

                            reader.Close();
                        }

                    }
                    catch (DbException se)
                    {
                        throw new Exception("[DAO] GetUser :\n" + se.Message, se);
                    }

                    return user;

                }//End using command
            }//End using connection

        }
    }
}
