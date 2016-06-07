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
        /// 
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
        /// 
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public void AddCLient(Client c)
        {
            cdao = new DAOClient();

            try
            {
                cdao.AddClient(c);

            }
            catch (Exception ex)
            {
                throw new BLLExceptionsClient("[BLL] AddClient : \n" + ex.Message, ex);
            }

        }

    }


}
