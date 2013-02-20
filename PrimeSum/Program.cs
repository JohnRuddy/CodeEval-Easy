using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeCount = 0;
            int primeSum = 0;
            int i = 2;
            while (primeCount < 1000)
            {
                if (IsPrime(i))
                {
                    primeCount = primeCount + 1;
                    primeSum = primeSum + i;
                }
                i = i + 1;
            }

            Console.WriteLine(primeSum);
            Console.Read();
        }

        static bool IsPrime(int number)
        {
            //check for evenness
            if (number % 2 == 0)
            {
                if (number == 2)
                {
                    return true;
                }
                return false;
            }
            //don't need to check past the square root
            int max = (int)Math.Sqrt(number);
            for (int i = 3; i <= max; i += 2)
            {
                if ((number % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
