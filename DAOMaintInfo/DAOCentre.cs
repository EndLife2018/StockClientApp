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
    public class DAOCentre
    {
        /// <summary>
        /// Execution de la procedure stocké 
        /// Recupere la liste de tous les centre par centre
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public List<Centre> GetCentresByIdClient(int num)
        {
            // return c.GetCatalogue;

            using (DbConnection db = DAOConnection.GetConnexion())
            {
                using (DbCommand cde = db.CreateCommand())
                {
                    cde.CommandText = "GetCentresByIdClient";
                    cde.CommandType = CommandType.StoredProcedure;

                    DbParameter odbP1 = cde.CreateParameter();
                    odbP1.DbType = System.Data.DbType.String;
                    odbP1.Direction = System.Data.ParameterDirection.Input;
                    odbP1.ParameterName = "@num";
                    odbP1.Value = num;
                    cde.Parameters.Add(odbP1);


                    List<Centre> lstClient = new List<Centre>();
                    try
                    {
                        using (DbDataReader reader = cde.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string nom = reader.GetString(1);
                                int clt = reader.GetInt32(2);
                                int sec = reader.GetInt32(3);

                                string adresse = reader.GetString(5);
                                string tel = reader.GetString(4);
                                string libsec = reader.GetString(6);
                                Secteur s = new Secteur { CodeSecteur = sec, LibelleSecteur = libsec };

                                Centre c = new Centre(id, nom , tel , adresse , null,  s);

                                lstClient.Add(c);
                            }

                            reader.Close();
                        }

                    }
                    catch (DbException se)
                    {
                        throw new DAOExceptionClient("[DAO] GetClientByName :\n" + se.Message, se);
                    }

                    return lstClient;

                }//End using command
            }//End using connection

        }

        /// <summary>
        /// Ajoute un centre dans la table Centre de la base de donnée maintinfo
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public int AddCentre(Centre c)
        {
            //  c.AddProduit(p);

            using (DbConnection db = DAOConnection.GetConnexion())
            {
                using (DbCommand cde = db.CreateCommand())
                {
                    cde.CommandText = "[dbo].[AddCentre]";
                    cde.CommandType = CommandType.StoredProcedure;


                    // Nom
                    DbParameter odbP1 = cde.CreateParameter();
                    odbP1.DbType = System.Data.DbType.String;
                    odbP1.Direction = System.Data.ParameterDirection.Input;
                    odbP1.ParameterName = "@nomCentre";
                    odbP1.Value = c.NomCentre;
                    cde.Parameters.Add(odbP1);
                    // Id secteur
                    DbParameter odbP2 = cde.CreateParameter();
                    odbP2.DbType = System.Data.DbType.Int32;
                    odbP2.Direction = System.Data.ParameterDirection.Input;
                    odbP2.ParameterName = "@idSecteur";
                    odbP2.Value = c.Secteur.CodeSecteur ;
                    cde.Parameters.Add(odbP2);

                    // telephone
                    DbParameter odbP3 = cde.CreateParameter();
                    odbP3.DbType = System.Data.DbType.String;
                    odbP3.Direction = System.Data.ParameterDirection.Input;
                    odbP3.ParameterName = "@telCentre";
                    odbP3.Value = c.TelCentre;
                    cde.Parameters.Add(odbP3);

                    // idCentre
                    DbParameter odbP4 = cde.CreateParameter();
                    odbP4.DbType = System.Data.DbType.Int32;
                    odbP4.Direction = System.Data.ParameterDirection.Output;
                    odbP4.ParameterName = "@idCentre";
                    cde.Parameters.Add(odbP4);

                    // Adresse
                    DbParameter odbP5 = cde.CreateParameter();
                    odbP5.DbType = System.Data.DbType.String;
                    odbP5.Direction = System.Data.ParameterDirection.Input;
                    odbP5.ParameterName = "@AdresseCentre";
                    odbP5.Value = c.AdresseCentre;
                    cde.Parameters.Add(odbP5);

                    // CLIENT
                    DbParameter odbP6 = cde.CreateParameter();
                    odbP6.DbType = System.Data.DbType.Int32;
                    odbP6.Direction = System.Data.ParameterDirection.Input;
                    odbP6.ParameterName = "@numClient";
                    odbP6.Value = c.Client.NumClient;
                    cde.Parameters.Add(odbP6);

                    try
                    {
                        int n = cde.ExecuteNonQuery();

                        if (n != 1)
                            throw new DAOExceptionClient("L'opération n'a pas été réalisée");
                        // récup du parametre de sortie



                        return (int)odbP4.Value;


                    }
                    catch (DbException de)
                    {
                        throw new DAOExceptionClient("[DAO] AddCentre \n" + de.Message, de);
                    }

                } // fin using command
            }// fin using connection

        }




       /// <summary>
       /// Mise à jour de la table Centre 
       /// </summary>
       /// <param name="c"></param>
       /// <returns></returns>
        public int UpdateCentre(Centre c)
        {

            using (DbConnection db = DAOConnection.GetConnexion())
            {
                using (DbCommand cde = db.CreateCommand())
                {
                    cde.CommandText = "[dbo].[UpdateCentre]";
                    cde.CommandType = CommandType.StoredProcedure;


                    // Nom
                    DbParameter odbP1 = cde.CreateParameter();
                    odbP1.DbType = System.Data.DbType.String;
                    odbP1.Direction = System.Data.ParameterDirection.Input;
                    odbP1.ParameterName = "@nomCentre";
                    odbP1.Value = c.NomCentre;
                    cde.Parameters.Add(odbP1);
                    // Id secteur
                    DbParameter odbP2 = cde.CreateParameter();
                    odbP2.DbType = System.Data.DbType.Int32;
                    odbP2.Direction = System.Data.ParameterDirection.Input;
                    odbP2.ParameterName = "@idSecteur";
                    odbP2.Value = c.Secteur.CodeSecteur;
                    cde.Parameters.Add(odbP2);

                    // telephone
                    DbParameter odbP3 = cde.CreateParameter();
                    odbP3.DbType = System.Data.DbType.String;
                    odbP3.Direction = System.Data.ParameterDirection.Input;
                    odbP3.ParameterName = "@telCentre";
                    odbP3.Value = c.TelCentre;
                    cde.Parameters.Add(odbP3);

                    // idCentre
                    DbParameter odbP4 = cde.CreateParameter();
                    odbP4.DbType = System.Data.DbType.Int32;
                    odbP4.Direction = System.Data.ParameterDirection.Input;
                    odbP4.ParameterName = "@idCentre";
                    odbP4.Value = c.NumCentre;
                    cde.Parameters.Add(odbP4);

                    // Adresse
                    DbParameter odbP5 = cde.CreateParameter();
                    odbP5.DbType = System.Data.DbType.String;
                    odbP5.Direction = System.Data.ParameterDirection.Input;
                    odbP5.ParameterName = "@AdresseCentre";
                    odbP5.Value = c.AdresseCentre;
                    cde.Parameters.Add(odbP5);

                    // CLIENT
                    DbParameter odbP6 = cde.CreateParameter();
                    odbP6.DbType = System.Data.DbType.Int32;
                    odbP6.Direction = System.Data.ParameterDirection.Input;
                    odbP6.ParameterName = "@numClient";
                    odbP6.Value = c.Client.NumClient;
                    cde.Parameters.Add(odbP6);
                    try
                    {
                        int n = cde.ExecuteNonQuery();

                        if (n != 1)
                            throw new DAOExceptionClient("L'opération n'a pas été réalisée");
                        // récup du parametre de sortie



                        return (int)odbP4.Value;


                    }
                    catch (DbException de)
                    {
                        throw new DAOExceptionClient("[DAO] UpdateCentre \n" + de.Message, de);
                    }

                } // fin using command
            }// fin using connection
        }
    }
}
