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
    public class TypeManager
    {
        DAOType cdao;

        /// <summary>
        /// Recupère la liste de tous les type d'équipements
        /// </summary>
        /// <returns></returns>
        public List<TypeEquipement> GetAllTypeEquipement()
        {
            cdao = new DAOType();
            
            try
            {
                return cdao.GetAllTypeEquipement();

            }
            catch (Exception ex)
            {
                throw new BLLExceptionTypeEquipement("[BLL] GetAllTypeEquipement : \n" + ex.Message, ex);
            }

        }

    }
}
