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

        public List<Equipement> GetEquipements(int search)
        {
            DAOEquipement cdao = new DAOEquipement();

           
            try
            {
                return cdao.GetEquipementByCentre(search);

            }
            catch (Exception ex)
            {
                throw new BLLExceptionsEquipement("[BLL] GetEquipements : \n" + ex.Message, ex);
            }

        }

        public int AddEquipements(Equipement equipement)
        {
            DAOEquipement cdao = new DAOEquipement();

            try
            {
                return cdao.AddEquipement(equipement);

            }
            catch (Exception ex)
            {
                throw new BLLExceptionsClient("[BLL] Add Equipement: \n" + ex.Message, ex);
            }

        }

        public int DelEquipements(int centre)
        {
            DAOEquipement cdao = new DAOEquipement();

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
