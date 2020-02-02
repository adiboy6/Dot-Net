using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorExceptionHandling
{
    class CustomException : ApplicationException
    {
        public CustomException(string message) : base(message)
        {

        }
    }
}
