using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace NModN
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
                    CalculateModulus(line);
                }

            Console.Read();
        }

        private static void CalculateModulus(string line)
        {
            var lineNumbers = line.Split(',');

            int a = int.Parse(lineNumbers[0]);
            int b = int.Parse(lineNumbers[1]); ;
            int divisible = a / b;
            int modulus = a - (divisible * b);

            Console.WriteLine(modulus);

        }
    }
}
