using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StreamReaderDaemi
{
    class StreamReaderDaemi
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("stuff.txt"))  //stuff.txt inniheldur tvær línur af texta
            {
                Console.WriteLine(reader.ReadLine());
            }

            Console.ReadLine();
        }
    }
}