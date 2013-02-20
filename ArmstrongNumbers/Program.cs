using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ArmstrongNumbers
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

                    CalculateArmstrongNumber(line);
                }

            Console.Read();
        }

        private static void CalculateArmstrongNumber(string line)
        {
            int n = line.Length;
            var sum = 0;

            for (int i = 0; i < line.Length; i++)
			{
                var numValue = int.Parse("" + line[i]);

			    sum = sum + CalculatePower(numValue,n);
            }


            Console.WriteLine("" + sum == line);
            //Console.WriteLine(string.Format("{0} - {1}"), line, "" + sum);
        }

        private static int CalculatePower(int p, int n)
        {
            var product = p;

            if (n == 1)
            {
                return p;
            }

            for (int i = 1; i < n; i++)
            {
                product = product * p;
            }

            return product;
        }

    }
}
