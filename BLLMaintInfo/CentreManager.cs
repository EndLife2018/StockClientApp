using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Accès
using BLLMaintInfo.Exceptions;
using BO;
using DAO;

namespace BLL
{
    public class CentreManager
    {

        DAOCentre cdao;

        /// <summary>
        /// Obtenir le liste des centre en fonction de l'id client
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<Centre> GetCentres(int search)
        {
            cdao = new DAOCentre();

            try
            {
                return cdao.GetCentresByIdClient(search);

            }
            catch (Exception ex)
            {
                throw new BLLExceptionsClient("[BLL] GetCentres : \n" + ex.Message, ex);
            }

        }

        /// <summary>
        /// Ajouter un centre 
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public int AddCentre(Centre c)
        {
            cdao = new DAOCentre();

            try
            {
                return cdao.AddCentre(c);

            }
            catch (Exception ex)
            {
                throw new BLLExceptionsClient("[BLL] AddCentre : \n" + ex.Message, ex);
            }

        }

        /// <summary>
        /// Mise à jour du centre
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public int UpdateCentre(Centre c)
        {
            cdao = new DAOCentre();

            try
            {
                return cdao.UpdateCentre(c);

            }
            catch (Exception ex)
            {
                throw new BLLExceptionsClient("[BLL] UpdateCentre : \n" + ex.Message, ex);
            }

        }

       

    }
}
