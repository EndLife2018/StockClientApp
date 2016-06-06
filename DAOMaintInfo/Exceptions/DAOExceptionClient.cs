using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOMaintInfo.Exceptions
{
    class DAOExceptionClient : DAOExceptions
    {
        public DAOExceptionClient() : base()
        {
        }

        public DAOExceptionClient(string message)
            : base(message)
        {
        }
        public DAOExceptionClient(string message, System.Exception inner)
            : base(message, inner)
        {
        }

    }
}
