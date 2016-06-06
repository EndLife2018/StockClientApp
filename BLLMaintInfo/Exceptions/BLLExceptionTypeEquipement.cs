using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLMaintInfo.Exceptions
{
    class BLLExceptionTypeEquipement : BLLExceptions
    {

        public BLLExceptionTypeEquipement() : base()
        {
        }

        public BLLExceptionTypeEquipement(string message)
            : base(message)
        {
        }
        public BLLExceptionTypeEquipement(string message, System.Exception inner)
            : base(message, inner)
        {
        }
    }
}
