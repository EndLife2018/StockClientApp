﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLMaintInfo.Exceptions
{
    class BLLExceptionsEquipement : BLLExceptions
    {

        public BLLExceptionsEquipement() : base()
        {
        }

        public BLLExceptionsEquipement(string message)
            : base(message)
        {
        }
        public BLLExceptionsEquipement(string message, System.Exception inner)
            : base(message, inner)
        {
        }
    }
}
