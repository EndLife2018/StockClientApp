using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOMaintInfo.Exceptions
{
    class DAOExceptionEquipement : DAOExceptions
    {

        public DAOExceptionEquipement() : base()
        {
        }

        public DAOExceptionEquipement(string message)
            : base(message)
        {
        }
        public DAOExceptionEquipement(string message, System.Exception inner)
            : base(message, inner)
        {
        }
    }
}
