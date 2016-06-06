using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLMaintInfo.Exceptions
{
    class BLLExceptionsClient : BLLExceptions
    {
        public BLLExceptionsClient() : base()
        {
        }

        public BLLExceptionsClient(string message)
            : base(message)
        {
        }
        public BLLExceptionsClient(string message, System.Exception inner)
            : base(message, inner)
        {
        }
    }
}
