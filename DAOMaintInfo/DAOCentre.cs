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
        /// 
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
                                int clt = reader.GetInt32(1);
                                int sec = reader.GetInt32(2);

                                string adresse = reader.GetString(4);
                                string tel = reader.GetString(3);


                                Centre c = new Centre(id, "vide" , tel , adresse ,null , null);

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
    }
}
