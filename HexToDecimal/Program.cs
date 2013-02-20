using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HexToDecimal
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
                    ConvertHexToDecimal(line);
                }

            Console.Read();
        }

        private static void ConvertHexToDecimal(string line)
        {
            int decValue = int.Parse(line, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine(decValue);
        }
    }
}
