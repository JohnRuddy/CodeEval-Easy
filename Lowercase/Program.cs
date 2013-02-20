using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Lowercase
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

                    Console.WriteLine(line.ToLower());
                }

            Console.Read();
        }
    }
}
