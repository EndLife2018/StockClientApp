using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLMaintInfo.Exceptions
{
    class BLLExceptionsCentre : BLLExceptions
    {
        public BLLExceptionsCentre() : base()
        {
        }

        public BLLExceptionsCentre(string message)
            : base(message)
        {
        }
        public BLLExceptionsCentre(string message, System.Exception inner)
            : base(message, inner)
        {

        }

    }
}
