using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            const int UPPER_BOUND = 12;

            for (int i = 1; i <= UPPER_BOUND; i++)
            {
                for (int j = 1; j <= UPPER_BOUND; j++)
                {
                    if (j == 1)
                    {
                        Console.Write(PadString(i * j + " ", 2));
                    }
                    else
                    {
                        Console.Write(PadString(i * j + " ", 4));
                    }   
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        private static string PadString(string p, int p_2)
        {   
            var padding = string.Empty;

            for (int i = 0; i < p_2; i++)
            {
                padding = padding + " ";
            }

            padding = padding + p;
            padding = padding.Substring(padding.Length - (p_2 + 1), p_2);
            return padding;
        }


    }
}
