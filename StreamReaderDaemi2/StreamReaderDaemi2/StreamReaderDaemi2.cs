using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StreamReaderDaemi2
{
    class StreamReaderDaemi2
    {
        static void Main(string[] args)
        {
            //Add using System.IO;
            List<string> lines = new List<string>(); //Used to store the lines

            using (StreamReader reader = new StreamReader("stuff.txt")) //Stuff.txt contains 5 lines of text
            {
                string line = null; 

                while ((line = reader.ReadLine()) != null) //Reads line after line until reader.ReadLine is blank
                {
                    lines.Add(line); //Adds every line to the list
                    Console.WriteLine(line); //Writes every line to console
                }
            }

            Console.ReadLine();
        }
    }
}
