using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimePallindrome
{
    class Program
    {
        public static IList<int> FindPrimes(int max)
        {
            var vals = new List<int>((int)(max / (Math.Log(max) - 1.08366)));
            var maxSquareRoot = Math.Sqrt(max);
            var eliminated = new System.Collections.BitArray(max + 1);

            vals.Add(2);

            for (int i = 3; i <= max; i += 2)
            {
                if (!eliminated[i])
                {
                    if (i < maxSquareRoot)
                    {
                        for (int j = i * i; j <= max; j += 2 * i)
                            eliminated[j] = true;
                    }
                    vals.Add(i);
                }
            }
            return vals;
        }

        static void Main(string[] args)
        {
            var primes = FindPrimes(1000);
            var largest = 0;

            foreach (var prime in primes)
            {
                if (isPalindrome("" + prime))
                {
                    largest = prime;   
                }
            }

            Console.WriteLine(largest);
            Console.Read();
        }

        public static bool isPalindrome(string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;

            int length = str.Length;

            str = str.ToLower();

            for (int i = 0; i < (length / 2); i++)
            {
                if (str[i] != str[length - 1 - i])
                    return false;
            }

            return true;
        }
    }
}
