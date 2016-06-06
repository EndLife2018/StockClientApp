using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// acces a la base de donnée
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Data.Common; // dbconnect

// accès exceptions 
using DAOMaintInfo.Exceptions;

namespace DAO
{
    class DAOConnection
    {

        /// <summary>
        /// Gestion de la connexion a la base en fonction du fichier app config
        /// </summary>
        /// <returns></returns>
        public static DbConnection GetConnexion()
        {


            ConnectionStringSettings oConfig = ConfigurationManager.ConnectionStrings["MaintInfo.Properties.Settings.MaintInfo"];

            if (oConfig == null) // chaine de connexion non trouvée
                                 //  throw new DaoExceptionFinAppli("La base est inaccessible, l'appplication va se fermer, recommencez ultérieurement: \n"
                                 //      + "La chaine de connexion est introuvable");
                return null;
            else
            {
                try
                {

                    DbProviderFactory oFabrique = DbProviderFactories.GetFactory(oConfig.ProviderName);
                    DbConnection db = oFabrique.CreateConnection();
                    db.ConnectionString = oConfig.ConnectionString;

                    db.Open();
                    return db;
                }
                catch( DbException ex )
                {
                    throw new DAOExceptionConnection("[DAO] GetConnection" + ex.Message , ex );
                }


            }

        }
    }
}
