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
            //Adda using System.IO;
            string line = null;

            using (StreamReader reader = new StreamReader("stuff.txt"))  //stuff.txt contains two lines of text
            {
                line = reader.ReadLine(); //Line will contain the first line of the document (stuff.txt)
            }

            Console.WriteLine(line); //Writes the first line 
            Console.ReadLine();
        }
    }
}
