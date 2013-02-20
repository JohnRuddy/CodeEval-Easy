using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public int NumberA { get; set; }
        public int NumberB { get; set; }
        public int Length { get; set; }

        public FizzBuzz(string line)
        {
            var inputs = line.Split(' ');
            NumberA = int.Parse(inputs[0]);
            NumberB = int.Parse(inputs[1]);
            Length = int.Parse(inputs[2]);
        }

        public void CalculateFizzBuzz()
        {
            for (int i = 1; i <= this.Length; i++)
            {
                var output = string.Empty;

                if (i % NumberA == 0)
                {
                    output = output + "F";
                }

                if (i % NumberB == 0)
                {
                    output = output + "B";
                }

                if (output == string.Empty)
                {
                    output = "" + i;
                }

                Console.Write(output + " ");

            }
            Console.WriteLine();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    FizzBuzz fb = new FizzBuzz(line);
                    fb.CalculateFizzBuzz();

                    if (null == line)
                        continue;
                    // do something with line
                }

            Console.Read();
        }
    }
}
