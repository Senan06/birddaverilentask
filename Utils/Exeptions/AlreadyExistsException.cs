using System;
using System.Collections.Generic;
using System.Text;

namespace Utils.Exeptions
{
    public class AlreadyExistsException:Exception
    {
        public AlreadyExistsException(string message) : base(message)
        {

        }
    }
}
