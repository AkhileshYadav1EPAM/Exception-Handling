using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedExceptionHandling
{
    internal class FitnessTestFailedException : Exception
    {
        public FitnessTestFailedException(string message) : base(message)  
        {

        }
    }
}
