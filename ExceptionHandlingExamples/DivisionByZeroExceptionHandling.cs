using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingExamples
{
    internal class DivisionByZeroExceptionHandling
    {
        public void DivisionBeZero()
        {
            int numeratorValue = 10;
            int denominatorValue = 0;

            try
            {
                int divisionResult = numeratorValue / denominatorValue;
                Console.WriteLine("The result of the division is " + divisionResult);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception Cought : " + e);
                Console.WriteLine("\n\n\n\n");

            }
            finally
            {
                Console.WriteLine("The finally block is executed");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("--------------------------------------------------");
            }
        }
    }
}
