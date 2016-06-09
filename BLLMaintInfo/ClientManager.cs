using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//accès
using BLLMaintInfo.Exceptions;
using BO;
using DAO;

namespace BLL
{
    public class ClientManager
    {

        private DAOClient cdao;


        /// <summary>
        ///  Recherche la liste des client dont le nom contient les lettres passé en paramètre
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<Client> Rechercher(string search)
        {
            cdao = new DAOClient();

            try
            {
                return cdao.GetClientsByName(search);

            }
            catch (Exception ex)
            {
                throw new BLLExceptionsClient("[BLL] Rechercher : \n" + ex.Message, ex);
            }

        }

        /// <summary>
        ///  Ajouter un client
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public int AddCLient(Client c)
        {
            cdao = new DAOClient();

            try
            {
                return  cdao.AddClient(c);

            }
            catch (Exception ex)
            {
                throw new BLLExceptionsClient("[BLL] AddClient : \n" + ex.Message, ex);
            }

        }

        /// <summary>
        /// Mise à jour du client
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public int UpdateCLient(Client c)
        {
            cdao = new DAOClient();

            try
            {
                return cdao.UpdateClient(c);

            }
            catch (Exception ex)
            {
                throw new BLLExceptionsClient("[BLL] UpdateClient : \n" + ex.Message, ex);
            }

        }



    }


}
