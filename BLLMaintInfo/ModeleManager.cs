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
        //public List<Modele> GetAllModeleByType(int type )
        //{
        //    DAOModele cdao = new DAOModele();


        //    try
        //    {
        //        return cdao.GetAllModeleByType(type);

        //    }
        //    catch (Exception ex)
        //    {
        //        throw new BLLExceptionModele("[BLL] GetAllModeleByType : \n" + ex.Message, ex);
        //    }

        //}

        public List<Modele> GetAllModele( )
        {
            DAOModele cdao = new DAOModele();


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
