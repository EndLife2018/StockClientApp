using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOMaintInfo.Exceptions
{
    class DAOExceptionSecteur : DAOExceptions
    {

        public DAOExceptionSecteur() : base()
        {
        }

        public DAOExceptionSecteur(string message)
            : base(message)
        {
        }
        public DAOExceptionSecteur(string message, System.Exception inner)
            : base(message, inner)
        {
        }
    }
}
