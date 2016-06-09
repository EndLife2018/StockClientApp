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
    public class EquipementManager
    {
        DAOEquipement cdao;

        /// <summary>
        /// Recherche la liste des equipements en fonction du centre
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<Equipement> GetEquipements(int search)
        {
            cdao = new DAOEquipement();

           
            try
            {
                return cdao.GetEquipementByCentre(search);

            }
            catch (Exception ex)
            {
                throw new BLLExceptionsEquipement("[BLL] GetEquipements : \n" + ex.Message, ex);
            }

        }

        /// <summary>
        ///  Ajoute un equipement pour un centre
        /// </summary>
        /// <param name="equipement"></param>
        /// <returns></returns>
        public int AddEquipements(Equipement equipement)
        {
            cdao = new DAOEquipement();

            try
            {
                return cdao.AddEquipement(equipement);

            }
            catch (Exception ex)
            {
                throw new BLLExceptionsClient("[BLL] Add Equipement: \n" + ex.Message, ex);
            }

        }

        /// <summary>
        /// Efface la liste des equipements appartenant à un centre
        /// </summary>
        /// <param name="centre"></param>
        /// <returns></returns>
        public int DelEquipements(int centre)
        {
            cdao = new DAOEquipement();

            try
            {
                return cdao.DelEquipement(centre);

            }
            catch (Exception ex)
            {
                throw new BLLExceptionsClient("[BLL] DelEquipement : \n" + ex.Message, ex);
            }

        }
    }
}
