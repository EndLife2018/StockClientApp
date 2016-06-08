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
    public class DAOClient
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        public int AddClient( Client c)
        {
            //  c.AddProduit(p);

            using (DbConnection db = DAOConnection.GetConnexion())
            {
                using (DbCommand cde = db.CreateCommand())
                {
                    cde.CommandText = "[dbo].[AddClient]";
                    cde.CommandType = CommandType.StoredProcedure;


                    // Nom
                    DbParameter odbP1 = cde.CreateParameter();
                    odbP1.DbType = System.Data.DbType.String;
                    odbP1.Direction = System.Data.ParameterDirection.Input;
                    odbP1.ParameterName = "@nom";
                    odbP1.Value = c.NomClient;
                    cde.Parameters.Add(odbP1);
                    // Adresse
                    DbParameter odbP2 = cde.CreateParameter();
                    odbP2.DbType = System.Data.DbType.String;
                    odbP2.Direction = System.Data.ParameterDirection.Input;
                    odbP2.ParameterName = "@adresse";
                    odbP2.Value = c.AdresseClient;
                    cde.Parameters.Add(odbP2);

                    // telephone
                    DbParameter odbP3 = cde.CreateParameter();
                    odbP3.DbType = System.Data.DbType.String;
                    odbP3.Direction = System.Data.ParameterDirection.Input;
                    odbP3.ParameterName = "@tel";
                    odbP3.Value = c.TelephoneClient;
                    cde.Parameters.Add(odbP3);

                    // idClient
                    DbParameter odbP4 = cde.CreateParameter();
                    odbP4.DbType = System.Data.DbType.Int32;
                    odbP4.Direction = System.Data.ParameterDirection.Output;
                    odbP4.ParameterName = "@idClient";
                    
                    cde.Parameters.Add(odbP4);
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
                        throw new DAOExceptionClient("[DAO] AddClient \n" + de.Message, de);
                    }

                } // fin using command
            }// fin using connection

        }




        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="p"></param>
        public int UpdateClient(Client c)
        {
            //  c.AddProduit(p);

            using (DbConnection db = DAOConnection.GetConnexion())
            {
                using (DbCommand cde = db.CreateCommand())
                {
                    cde.CommandText = "[dbo].[UpdateClient]";
                    cde.CommandType = CommandType.StoredProcedure;


                    // Nom
                    DbParameter odbP1 = cde.CreateParameter();
                    odbP1.DbType = System.Data.DbType.String;
                    odbP1.Direction = System.Data.ParameterDirection.Input;
                    odbP1.ParameterName = "@nom";
                    odbP1.Value = c.NomClient;
                    cde.Parameters.Add(odbP1);
                    // Adresse
                    DbParameter odbP2 = cde.CreateParameter();
                    odbP2.DbType = System.Data.DbType.String;
                    odbP2.Direction = System.Data.ParameterDirection.Input;
                    odbP2.ParameterName = "@adresse";
                    odbP2.Value = c.AdresseClient;
                    cde.Parameters.Add(odbP2);

                    // telephone
                    DbParameter odbP3 = cde.CreateParameter();
                    odbP3.DbType = System.Data.DbType.String;
                    odbP3.Direction = System.Data.ParameterDirection.Input;
                    odbP3.ParameterName = "@tel";
                    odbP3.Value = c.TelephoneClient;
                    cde.Parameters.Add(odbP3);

                    // idClient
                    DbParameter odbP4 = cde.CreateParameter();
                    odbP4.DbType = System.Data.DbType.Int32;
                    odbP4.Direction = System.Data.ParameterDirection.Input;
                    odbP4.Value = c.NumClient;
                    odbP4.ParameterName = "@idClient";

                    cde.Parameters.Add(odbP4);
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
                        throw new DAOExceptionClient("[DAO] AddClient \n" + de.Message, de);
                    }

                } // fin using command
            }// fin using connection
        }

      

            /// <summary>
            /// 
            /// </summary>
            /// <param name="n"></param>
            /// <returns></returns>
        public List<Client> GetClientsByName(string n)
        {
            // return c.GetCatalogue;

            using (DbConnection db = DAOConnection.GetConnexion())
            {
                using (DbCommand cde = db.CreateCommand())
                {
                    cde.CommandText = "GetClientsByName";
                    cde.CommandType = CommandType.StoredProcedure;

                    DbParameter odbP1 = cde.CreateParameter();
                    odbP1.DbType = System.Data.DbType.String;
                    odbP1.Direction = System.Data.ParameterDirection.Input;
                    odbP1.ParameterName = "@name";
                    odbP1.Value = n;
                    cde.Parameters.Add(odbP1);


                    List<Client> lstClient = new List<Client>();
                    try
                    {
                        using (DbDataReader reader = cde.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string nom = reader.GetString(1);
                                string adresse = reader.GetString(2);
                                string tel = reader.GetString(3);


                                Client clt = new Client(id,nom,adresse,tel);

                                lstClient.Add(clt);
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

    } // fin class DAOCLient
}
