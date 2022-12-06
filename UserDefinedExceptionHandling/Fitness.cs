using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedExceptionHandling
{
    internal class Fitness
    {
        int points = 90;

        public void showResult()
        {
            if (points < 80)
            {
                throw (new FitnessTestFailedException("Player failed the fitness test!"));
            }
            else
            {
                Console.WriteLine("Player passed the fitness test!");
            }
        }
    }
}
