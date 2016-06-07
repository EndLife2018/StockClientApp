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
        public void AddClient( Client c)
        {
            //  c.AddProduit(p);

            using (DbConnection db = DAOConnection.GetConnexion())
            {
                using (DbCommand cde = db.CreateCommand())
                {
                    cde.CommandText = "[dbo].[AddClient]";
                    cde.CommandType = CommandType.StoredProcedure;


                    // CPU
                    DbParameter odbP1 = cde.CreateParameter();
                    odbP1.DbType = System.Data.DbType.String;
                    odbP1.Direction = System.Data.ParameterDirection.Input;
                    odbP1.ParameterName = "@nom";
                    odbP1.Value = c.NomClient;
                    cde.Parameters.Add(odbP1);
                    // Libelle
                    DbParameter odbP2 = cde.CreateParameter();
                    odbP2.DbType = System.Data.DbType.String;
                    odbP2.Direction = System.Data.ParameterDirection.Input;
                    odbP2.ParameterName = "@adresse";
                    odbP2.Value = c.AdresseClient;
                    cde.Parameters.Add(odbP2);

                    // Prix
                    DbParameter odbP3 = cde.CreateParameter();
                    odbP3.DbType = System.Data.DbType.String;
                    odbP3.Direction = System.Data.ParameterDirection.Input;
                    odbP3.ParameterName = "@tel";
                    odbP3.Value = c.TelephoneClient;
                    cde.Parameters.Add(odbP3);


                    try
                    {
                        int n = cde.ExecuteNonQuery();

                        // Pour ne pas obliger chaque proc sto Insert à retourner un identifiant int
                        // on pourrait retourner la valeur du dernier parametre sous forme d'objet

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
        ///// <returns></returns>
        //public List<Produit> GetCatalogue()
        //{
        //    // return c.GetCatalogue;

        //    using (DbConnection db = ConnectionDAO.GetConnexion())
        //    {
        //        using (DbCommand cde = db.CreateCommand())
        //        {
        //            cde.CommandText = "[dbo].[GetAllProduits]";
        //            cde.CommandType = CommandType.StoredProcedure;


        //            List<Produit> lstProduits = new List<Produit>();
        //            try
        //            {
        //                using (DbDataReader reader = cde.ExecuteReader())
        //                {
        //                    while (reader.Read())
        //                    {
        //                        int cpu = reader.GetInt32(0);
        //                        string libelle = reader.GetString(1);
        //                        double prix = (double)reader.GetDecimal(2);
        //                        Produit prod = new Produit(cpu, libelle, prix);

        //                        lstProduits.Add(prod);
        //                    }

        //                    reader.Close();
        //                }

        //            }
        //            catch (DbException se)
        //            {
        //                throw new DAOCatalogue("[DAO] GetCatalogue " + se.Message, se);
        //            }

        //            return lstProduits;

        //        }//End using command
        //    }//End using connection




        //}


        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="p"></param>
        //public void DelProduit(Produit p)
        //{
        //    // création connection
        //    using (DbConnection db = ConnectionDAO.GetConnexion())
        //    {
        //        using (DbCommand cde = db.CreateCommand())
        //        {
        //            try
        //            {
        //                cde.CommandText = "[dbo].[DelProduit]";
        //                cde.CommandType = CommandType.StoredProcedure;

        //                // affectation parametres à la commande


        //                int n = cde.ExecuteNonQuery();
        //                if (n != 1)
        //                    throw new DAOCatalogue("L'opération de suppression n'a pas été réalisée");
        //            }
        //            catch (DbException se)
        //            {
        //                throw new DAOCatalogue("[DAO] __Suppression__ \nUne erreur s'est produite sur la base :\n" + se.Message, se);
        //            }
        //        }
        //    }

        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="p"></param>
        //public void ModifierProduit(Produit p)
        //{

        //    // création connection
        //    using (DbConnection db = ConnectionDAO.GetConnexion())
        //    {
        //        using (DbCommand cde = db.CreateCommand())
        //        {
        //            try
        //            {
        //                cde.CommandText = "[dbo].[UpdateProduit]";
        //                cde.CommandType = CommandType.StoredProcedure;
        //                // CPU
        //                DbParameter odbP1 = cde.CreateParameter();
        //                odbP1.DbType = System.Data.DbType.Int32;
        //                odbP1.Direction = System.Data.ParameterDirection.Input;
        //                odbP1.ParameterName = "@cpu";
        //                odbP1.Value = p.Cpu;
        //                cde.Parameters.Add(odbP1);
        //                // Libelle
        //                DbParameter odbP2 = cde.CreateParameter();
        //                odbP2.DbType = System.Data.DbType.String;
        //                odbP2.Direction = System.Data.ParameterDirection.Input;
        //                odbP2.ParameterName = "@libelle";
        //                odbP2.Value = p.Libelle;
        //                cde.Parameters.Add(odbP2);

        //                // Prix
        //                DbParameter odbP3 = cde.CreateParameter();
        //                odbP3.DbType = System.Data.DbType.Double;
        //                odbP3.Direction = System.Data.ParameterDirection.Input;
        //                odbP3.ParameterName = "@prix";
        //                odbP3.Value = p.Prix;
        //                cde.Parameters.Add(odbP3);


        //                int n = cde.ExecuteNonQuery();
        //                if (n != 1)
        //                    throw new DAOCatalogue("L'opération de mise à jour n'a pas été réalisée\n");
        //            }
        //            catch (DbException se)
        //            {
        //                throw new DAOCatalogue("[DAO] Modifier Produit : \n" + se.Message, se);
        //            }
        //        }
        //    }
        //}


        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="c"></param>
        ///// <returns></returns>
        //public List<Produit> GetProduitsByCpu(int c)
        //{
        //    // return c.GetCatalogue;

        //    using (DbConnection db = ConnectionDAO.GetConnexion())
        //    {
        //        using (DbCommand cde = db.CreateCommand())
        //        {
        //            cde.CommandText = "GetProduitsByCpu";
        //            cde.CommandType = CommandType.StoredProcedure;

        //            DbParameter odbP1 = cde.CreateParameter();
        //            odbP1.DbType = System.Data.DbType.Int32;
        //            odbP1.Direction = System.Data.ParameterDirection.Input;
        //            odbP1.ParameterName = "@cpu";
        //            odbP1.Value = c;
        //            cde.Parameters.Add(odbP1);


        //            List<Produit> lstProduits = new List<Produit>();
        //            try
        //            {
        //                using (DbDataReader reader = cde.ExecuteReader())
        //                {
        //                    while (reader.Read())
        //                    {
        //                        int cpu = reader.GetInt32(0);
        //                        string libelle = reader.GetString(1);
        //                        double prix = (double)reader.GetDecimal(2);
        //                        Produit prod = new Produit(cpu, libelle, prix);

        //                        lstProduits.Add(prod);
        //                    }

        //                    reader.Close();
        //                }

        //            }
        //            catch (DbException se)
        //            {
        //                throw new DAOCatalogue("[DAO] GetProductsByCpu " + se.Message, se);
        //            }

        //            return lstProduits;

        //        }//End using command
        //    }//End using connection

        //}

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
