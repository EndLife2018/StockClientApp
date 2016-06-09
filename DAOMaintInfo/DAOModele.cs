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
    public class DAOModele
    {

        /// <summary>
        /// Recupère la liste de tous les Modèles
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<Modele> GetAllModele()
        {


            using (DbConnection db = DAOConnection.GetConnexion())
            {
                using (DbCommand cde = db.CreateCommand())
                {
                    cde.CommandText = "GetAllModele";
                    cde.CommandType = CommandType.StoredProcedure;


                    List<Modele> modeles = new List<Modele>();
                    try
                    {
                        using (DbDataReader reader = cde.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int idmodele = reader.GetInt32(0);
                                string libellemodele = reader.GetString(1);
                                
                                modeles.Add(new Modele(idmodele, libellemodele));
                            }

                            reader.Close();
                        }

                    }
                    catch (DbException se)
                    {
                        throw new DAOExceptionSecteur("[DAO] GetAllMOdele :\n" + se.Message, se);
                    }

                    return modeles;

                }//End using command
            }//End using connection

        }
    }
}
