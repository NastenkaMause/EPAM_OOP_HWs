using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_18_01T06H12H
{
    internal class RangeException : Exception
    {
        internal RangeException(string exceptionMessage) : base(exceptionMessage)
        {

        }
    }

    internal class ExistException : Exception
    {
        internal ExistException(string exceptionMessage) : base(exceptionMessage)
        {

        }
    }
}
