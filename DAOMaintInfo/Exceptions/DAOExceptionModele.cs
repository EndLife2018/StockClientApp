using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOMaintInfo.Exceptions
{
    class DAOExceptionModele : DAOExceptions
    {

        public DAOExceptionModele() : base()
        {
        }

        public DAOExceptionModele(string message)
            : base(message)
        {
        }
        public DAOExceptionModele(string message, System.Exception inner)
            : base(message, inner)
        {
        }
    }
}
