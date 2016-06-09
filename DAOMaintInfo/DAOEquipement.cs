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
    public  class DAOEquipement
    {
        /// <summary>
        /// Execution de la procedure stocké 
        /// Recupere la liste de tous les equipements par centre
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public List<Equipement> GetEquipementByCentre(int num)
        {

            using (DbConnection db = DAOConnection.GetConnexion())
            {
                using (DbCommand cde = db.CreateCommand())
                {
                    cde.CommandText = "GetEquipementsByIdCentre";
                    cde.CommandType = CommandType.StoredProcedure;

                    DbParameter odbP1 = cde.CreateParameter();
                    odbP1.DbType = System.Data.DbType.String;
                    odbP1.Direction = System.Data.ParameterDirection.Input;
                    odbP1.ParameterName = "@num";
                    odbP1.Value = num;
                    cde.Parameters.Add(odbP1);


                    List<Equipement> lstEqui = new List<Equipement>();
                    try
                    {
                        using (DbDataReader reader = cde.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string numSerie = reader.GetString(0);
                                string nomModele = reader.GetString(1);
                                int numModele = reader.GetInt32(2);
                                decimal tarif = reader.GetDecimal(3);
                                int codetarif = reader.GetInt32(4);
                                string typeE = reader.GetString(5);
                                int idtype = reader.GetInt32(6);

                                 DateTime? dt = reader.GetDateTime(7);
                                
                                TypeEquipement te = new TypeEquipement(0,typeE );
                                Tarif Letarif = new Tarif( Convert.ToDouble( tarif ) ,dt );
                                Modele m = new Modele(numModele,nomModele ,Letarif ,te);


                                Equipement e = new Equipement(m,numSerie);

                                lstEqui.Add(e);
                            }

                            reader.Close();
                        }

                    }
                    catch (DbException se)
                    {
                        throw new DAOExceptionClient("[DAO] GetClientByName :\n" + se.Message, se);
                    }

                    return lstEqui;

                }//End using command
            }//End using connection

        }

        /// <summary>
        /// Ajoute dans le table Equipements 
        /// </summary>
        /// <param name="equipement"></param>
        /// <returns></returns>
        public int AddEquipement(Equipement equipement)
        {

            using (DbConnection db = DAOConnection.GetConnexion())
            {
                using (DbCommand cde = db.CreateCommand())
                {
                    cde.CommandText = "[dbo].[AddEquipement]";
                    cde.CommandType = CommandType.StoredProcedure;


                    // Nom
                    DbParameter odbP1 = cde.CreateParameter();
                    odbP1.DbType = System.Data.DbType.String;
                    odbP1.Direction = System.Data.ParameterDirection.Input;
                    odbP1.ParameterName = "@numserie";
                    odbP1.Value = equipement.NumSerie ;
                    cde.Parameters.Add(odbP1);
                    // MODELE
                    DbParameter odbP2 = cde.CreateParameter();
                    odbP2.DbType = System.Data.DbType.Int32;
                    odbP2.Direction = System.Data.ParameterDirection.Input;
                    odbP2.ParameterName = "@idmodele";
                    odbP2.Value = equipement.Modele.CodeModele ;
                    cde.Parameters.Add(odbP2);

                    // CENTRE
                    DbParameter odbP3 = cde.CreateParameter();
                    odbP3.DbType = System.Data.DbType.Int32;
                    odbP3.Direction = System.Data.ParameterDirection.Input;
                    odbP3.ParameterName = "@numcentre";
                    odbP3.Value = equipement.Centre.NumCentre ;
                    cde.Parameters.Add(odbP3);


                    try
                    {
                        int n = cde.ExecuteNonQuery();

                        if (n != 1)
                            throw new DAOExceptionClient("L'opération n'a pas été réalisée");
                        // récup du parametre de sortie

                        return n;


                    }
                    catch (DbException de)
                    {
                        throw new DAOExceptionClient("[DAO] AddEquipement \n" + de.Message, de);
                    }

                } // fin using command
            }// fin using connection

        }

      

        /// <summary>
        /// Efface de la table Equipement tous les equipements par centre
        /// </summary>
        /// <param name="centre"></param>
        /// <returns></returns>
        public int DelEquipement(int centre)
        {

            using (DbConnection db = DAOConnection.GetConnexion())
            {
                using (DbCommand cde = db.CreateCommand())
                {
                    cde.CommandText = "[dbo].[DelEquipement]";
                    cde.CommandType = CommandType.StoredProcedure;


                   

                    // CENTRE
                    DbParameter odbP3 = cde.CreateParameter();
                    odbP3.DbType = System.Data.DbType.Int32;
                    odbP3.Direction = System.Data.ParameterDirection.Input;
                    odbP3.ParameterName = "@idCentre";
                    odbP3.Value = centre;
                    cde.Parameters.Add(odbP3);

                    try
                    {
                        int n = cde.ExecuteNonQuery();

                        if (n != 1)
                            throw new DAOExceptionClient("L'opération n'a pas été réalisée");
                        // récup du parametre de sortie



                        return n;


                    }
                    catch (DbException de)
                    {
                        throw new DAOExceptionClient("[DAO] DELEquipement \n" + de.Message, de);
                    }

                } // fin using command
            }// fin using connection
        }

    }
}
