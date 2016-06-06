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
        public List<Equipement> GetEquipementByCentre(int num)
        {
            // return c.GetCatalogue;

            using (DbConnection db = DAOConnection.GetConnexion())
            {
                using (DbCommand cde = db.CreateCommand())
                {
                    cde.CommandText = "GetEquipementByIdCentre";
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
                                int numSerie = reader.GetInt32(0);
                                string nomModele = reader.GetString(1);
                                int numModele = reader.GetInt32(2);
                                double tarif = reader.GetDouble(3);
                                int codetarif = reader.GetInt32(4);
                                string typeE = reader.GetString(5);
                                int idtype = reader.GetInt32(6);
                                DateTime dt = reader.GetDateTime(7);
                                TypeEquipement te = new TypeEquipement(idtype,typeE );
                                Tarif Letarif = new Tarif(tarif, dt);
                                Modele m = new Modele(numModele,nomModele ,Letarif ,te);


                                Equipement e = new Equipement(m);

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
    }
}
