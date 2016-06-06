using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOMaintInfo.Exceptions
{
    class DAOExceptions : Exception
    {
        public DAOExceptions(): base()
        {
        }

        public  DAOExceptions(string message)
            : base(message)
        {
        }
        public DAOExceptions(string message, System.Exception inner)
            : base(message, inner)
        {
        }

    }
}
