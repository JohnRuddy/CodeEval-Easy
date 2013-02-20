using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BitPositions
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

                    CalculateBitPositions(line);

                }
            Console.Read();
        }

        private static void CalculateBitPositions(string line)
        {
            var inputs = line.Split(',');

            var number = int.Parse(inputs[0]);
            var positionA = int.Parse(inputs[1]);
            var positionB = int.Parse(inputs[2]);

            var binaryRepresentation = GetBinaryNumber(number);
            var bitPositionsMatch = CheckBitPositions(positionA, positionB, binaryRepresentation);
            Console.WriteLine(bitPositionsMatch);


        }

        private static string CheckBitPositions(int positionA, int positionB, string binaryRepresentation)
        {
            string returnValue = "false";

            var bits = binaryRepresentation.ToCharArray();
            bits = (from b in bits
                   select b).Reverse<char>().ToArray<char>();
            if (bits[positionA - 1] == bits[positionB - 1])
                returnValue = "true";

            return returnValue;
        }

        private static string GetBinaryNumber(int number)
        {
            int baseValue = 2; 
            string binary = Convert.ToString(number, baseValue); 
            return binary;
        }
    }
}
