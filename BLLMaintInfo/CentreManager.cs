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

        public int AddCentre(Centre c)
        {
            DAOCentre cdao = new DAOCentre();

            try
            {
                return cdao.AddCentre(c);

            }
            catch (Exception ex)
            {
                throw new BLLExceptionsClient("[BLL] AddCentre : \n" + ex.Message, ex);
            }

        }

        public int UpdateCentre(Centre c)
        {
            DAOCentre cdao = new DAOCentre();

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
