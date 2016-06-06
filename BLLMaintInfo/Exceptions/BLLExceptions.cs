using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLLMaintInfo.Exceptions
{
    class BLLExceptions : Exception
    {
        public BLLExceptions(): base()
        {
        }

        public BLLExceptions(string message)
            : base(message)
        {
        }
        public BLLExceptions(string message, System.Exception inner)
            : base(message, inner)
        {
        }
    }
}
