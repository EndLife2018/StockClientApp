using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLMaintInfo.Exceptions
{
    class BLLExceptionSecteur :BLLExceptions
    {
        public BLLExceptionSecteur() : base()
        {
        }

        public BLLExceptionSecteur(string message)
            : base(message)
        {
        }
        public BLLExceptionSecteur(string message, System.Exception inner)
            : base(message, inner)
        {

        }
    }
}
