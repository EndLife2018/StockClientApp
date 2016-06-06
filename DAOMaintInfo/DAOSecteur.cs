using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//accès exceptions 
using DAOMaintInfo.Exceptions;
using System.Data.Common;
using System.Data;
using BO;

namespace DAO
{
    public class DAOSecteur
    {

        public List<Secteur> GetAllSecteur()
        {
           

            using (DbConnection db = DAOConnection.GetConnexion())
            {
                using (DbCommand cde = db.CreateCommand())
                {
                    cde.CommandText = "GetAllSecteur";
                    cde.CommandType = CommandType.StoredProcedure;

                    
                    List<Secteur> secteurs = new List<Secteur>();
                    try
                    {
                        using (DbDataReader reader = cde.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int numSecteur = reader.GetInt32(0);
                                string nomSecteur = reader.GetString(1);
                                
                               
                                secteurs.Add( new Secteur(numSecteur, nomSecteur)) ;
                            }

                            reader.Close();
                        }

                    }
                    catch (DbException se)
                    {
                        throw new DAOExceptionSecteur("[DAO] GetAllSecteur :\n" + se.Message, se);
                    }

                    return secteurs;

                }//End using command
            }//End using connection

        }

    }
}
