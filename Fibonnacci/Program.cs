using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Fibonnacci
{
    class Program
    {

        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();


                    if (null == line)
                        continue;
                    // do something with line

                    CalculateFibonacci(line);
                }

            Console.Read();
        }

        private static void CalculateFibonacci(string line)
        {
            var j = int.Parse(line);

            if (j == 0)
            {
                Console.WriteLine(0);
                return;
            }

            if (j == 1)
            {
                Console.WriteLine(1);
                return;
            }



            var previousprevious = 0;
            var previous = 1;
            var currentSum = 0;

            for (int i = 2; i <= int.Parse(line); i++)
            {
                currentSum = previous + previousprevious;

                previousprevious = previous;
                previous = currentSum;

            }
            Console.WriteLine(currentSum);
        }

    }
}
