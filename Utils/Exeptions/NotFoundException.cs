using System;
using System.Collections.Generic;
using System.Text;

namespace Utils.Exeptions
{
    public class NotFoundException:Exception
    {
        public NotFoundException(string message) : base(message)
        {

        }
    }
}
