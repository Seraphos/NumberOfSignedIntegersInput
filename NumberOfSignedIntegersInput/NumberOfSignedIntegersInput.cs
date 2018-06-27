using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfSignedIntegersInput
{
    class NumberOfSignedIntegersInput
    {
        static void Main(string[] args)
        {
            int numInput1, numInput2, numInput3, numInput4, numInput5;
            Console.WriteLine("Enter 5 Integer values: ");
            numInput1 = Convert.ToInt32(Console.ReadLine());
            numInput2 = Convert.ToInt32(Console.ReadLine());
            numInput3 = Convert.ToInt32(Console.ReadLine());
            numInput4 = Convert.ToInt32(Console.ReadLine());
            numInput5 = Convert.ToInt32(Console.ReadLine());
            //integers for accumulating the number of signed integers
            int numberOfNegatives = 0, numberOfPositives = 0;
            //determining the number of negative entries
            if (numInput1 < 0)
                numberOfNegatives = numberOfNegatives + 1;
            if (numInput2 < 0)
                numberOfNegatives = numberOfNegatives + 1;
            if (numInput3 < 0)
                numberOfNegatives = numberOfNegatives + 1;
            if (numInput4 < 0)
                numberOfNegatives = numberOfNegatives + 1;
            if (numInput5 < 0)
                numberOfNegatives = numberOfNegatives + 1;
            //determining the number of positive entries
            if (numInput1 > 0)
                numberOfPositives = numberOfPositives + 1;
            if (numInput2 > 0)
                numberOfPositives = numberOfPositives + 1;
            if (numInput3 > 0)
                numberOfPositives = numberOfPositives + 1;
            if (numInput4 > 0)
                numberOfPositives = numberOfPositives + 1;
            if (numInput5 > 0)
                numberOfPositives = numberOfPositives + 1;
            Console.WriteLine("The number of positive integers you entered was {0}, the number of negative integers you entered was {1}", numberOfPositives, numberOfNegatives);
            Console.ReadKey();
        }
    }
}
