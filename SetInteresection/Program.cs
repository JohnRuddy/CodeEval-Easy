using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SetInteresection
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
                    ProcessSetIntersection(line);
                }

            Console.Read();
        }

        private static void ProcessSetIntersection(string arrayValue)
        {
            var outputString = string.Empty;

            string arr = arrayValue;
            var sets = arr.Split(';');

            var setA = sets[0].Split(',');
            var setB = sets[1].Split(',');
            var intersection = setA.Intersect(setB);

            foreach (var item in intersection)
            {
                outputString = outputString + item;
                if (!intersection.Last<string>().Equals(item))
                {
                    outputString = outputString + ",";
                }
            }

            Console.WriteLine(outputString);
        }
    }
}
