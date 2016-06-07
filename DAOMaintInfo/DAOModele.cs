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

        public List<Modele> GetAllModeleByType( int type)
        {


            using (DbConnection db = DAOConnection.GetConnexion())
            {
                using (DbCommand cde = db.CreateCommand())
                {
                    cde.CommandText = "GetAllModeleByType";
                    cde.CommandType = CommandType.StoredProcedure;


                    DbParameter odbP1 = cde.CreateParameter();
                    odbP1.DbType = System.Data.DbType.String;
                    odbP1.Direction = System.Data.ParameterDirection.Input;
                    odbP1.ParameterName = "@type";
                    odbP1.Value = type;
                    cde.Parameters.Add(odbP1);


                    List<Modele> modeles = new List<Modele>();
                    try
                    {
                        using (DbDataReader reader = cde.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int idmodele = reader.GetInt32(0);
                                string libellemodele = reader.GetString(1);
                                int codeTarif = reader.GetInt32(2);
                                decimal tarifmodele = reader.GetDecimal(3);
                                DateTime dt = reader.GetDateTime(4);


                                modeles.Add(new Modele(idmodele, libellemodele ));
                            }

                            reader.Close();
                        }

                    }
                    catch (DbException se)
                    {
                        throw new DAOExceptionSecteur("[DAO] GetAllSecteur :\n" + se.Message, se);
                    }

                    return modeles;

                }//End using command
            }//End using connection

        }


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
