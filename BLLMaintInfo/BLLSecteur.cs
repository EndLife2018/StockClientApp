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
    public class BLLSecteur
    {

        public List<Secteur> GetAllSecteur()
        {
            DAOSecteur cdao = new DAOSecteur();


            try
            {
                return cdao.GetAllSecteur();

            }
            catch (Exception ex)
            {
                throw new BLLExceptionSecteur("[BLL] GetAllSecteur : \n" + ex.Message, ex);
            }

        }
    }
}
