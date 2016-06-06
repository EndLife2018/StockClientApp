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
    public class BLLEquipement
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
    }
}
