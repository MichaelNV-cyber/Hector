using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hector
{
    internal abstract class types
    {
        public enum actionType
        {
            request,
            response,
            unspecified
        }

        public enum messageType
        {
            startComm,
            endComm,
            classification,
            unspecified
        }
    }
}
