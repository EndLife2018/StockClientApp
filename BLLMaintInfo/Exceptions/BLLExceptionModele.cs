using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLMaintInfo.Exceptions
{
    class BLLExceptionModele : BLLExceptions
    {

        public BLLExceptionModele() : base()
        {
        }

        public BLLExceptionModele(string message)
            : base(message)
        {
        }
        public BLLExceptionModele(string message, System.Exception inner)
            : base(message, inner)
        {
        }
    }
}
