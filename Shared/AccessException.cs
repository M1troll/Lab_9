using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class AccessException:Exception
    {
        public AccessException() : base() { }
        public AccessException(string message) : base(message) { }
        public AccessException(string message,Exception innerException) : base(message,innerException) { }
    }
}
