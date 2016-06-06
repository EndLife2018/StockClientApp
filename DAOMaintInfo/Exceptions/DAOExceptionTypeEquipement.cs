using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOMaintInfo.Exceptions
{
    class DAOExceptionTypeEquipement : DAOExceptions
    {

        public DAOExceptionTypeEquipement() : base()
        {
        }

        public DAOExceptionTypeEquipement(string message)
            : base(message)
        {
        }
        public DAOExceptionTypeEquipement(string message, System.Exception inner)
            : base(message, inner)
        {
        }
    }
}
