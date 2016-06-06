using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOMaintInfo.Exceptions
{
    class DAOExceptionCentre : DAOExceptions
    {

        public DAOExceptionCentre() : base()
        {
        }

        public DAOExceptionCentre(string message)
            : base(message)
        {
        }
        public DAOExceptionCentre(string message, System.Exception inner)
            : base(message, inner)
        {
        }
    }
}
