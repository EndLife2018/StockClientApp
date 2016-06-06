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
    public class DAOType
    {
        public List<TypeEquipement> GetAllTypeEquipement()
        {


            using (DbConnection db = DAOConnection.GetConnexion())
            {
                using (DbCommand cde = db.CreateCommand())
                {
                    cde.CommandText = "GetAllTypeEquipement";
                    cde.CommandType = CommandType.StoredProcedure;


                    List<TypeEquipement> equipements = new List<TypeEquipement>();
                    try
                    {
                        using (DbDataReader reader = cde.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int numType = reader.GetInt32(0);
                                string nomType = reader.GetString(1);


                                equipements.Add(new TypeEquipement(numType, nomType));
                            }

                            reader.Close();
                        }

                    }
                    catch (DbException se)
                    {
                        throw new DAOExceptionTypeEquipement("[DAO] GetAllTypeEquipement :\n" + se.Message, se);
                    }

                    return equipements;

                }//End using command
            }//End using connection

        }


    }
}
