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
    public class ModeleManager
    {
        DAOModele cdao;

        /// <summary>
        /// Recupere la liste de tous les modèles
        /// </summary>
        /// <returns></returns>
        public List<Modele> GetAllModele( )
        {
            cdao = new DAOModele();


            try
            {
                return cdao.GetAllModele();

            }
            catch (Exception ex)
            {
                throw new BLLExceptionModele("[BLL] GetAllModeleByType : \n" + ex.Message, ex);
            }

        }

    }
}
