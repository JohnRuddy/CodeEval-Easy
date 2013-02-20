using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileSize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetFileSize(args[0]));
            Console.Read();
        }

        private static string GetFileSize(string p)
        {
            FileInfo f = new FileInfo(p);
            string fileSize = f.Length.ToString();
            return fileSize;
        }
    }
}
