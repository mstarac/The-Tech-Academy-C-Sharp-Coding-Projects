using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedExceptionHandling
{
    public class Class : Exception
    {
        public Class() : base() { }

        public Class(string message) : base(message) { }
    }
}
