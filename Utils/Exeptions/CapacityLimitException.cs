using System;
using System.Collections.Generic;
using System.Text;

namespace Utils.Exeptions
{
    public class CapacityLimitException:Exception
    {
        public CapacityLimitException(string message):base(message)
        {

        }
    }
}
