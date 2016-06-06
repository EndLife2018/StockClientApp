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
    public class BLLCentre
    {
        public List<Centre> GetCentres(int search)
        {
            DAOCentre cdao = new DAOCentre();

            try
            {
                return cdao.GetCentresByIdClient(search);

            }
            catch (Exception ex)
            {
                throw new BLLExceptionsClient("[BLL] GetCentres : \n" + ex.Message, ex);
            }

        }
    }
}
