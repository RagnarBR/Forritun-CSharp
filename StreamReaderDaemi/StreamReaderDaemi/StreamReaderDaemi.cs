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

            using (StreamReader reader = new StreamReader("stuff.txt"))  //stuff.txt inniheldur tvær línur af texta
            {
                line = reader.ReadLine(); //Line verður innihald fyrstu línunnar í skjalinu
            }

            Console.WriteLine(line); //Skrifar út fyrstu línuna
            Console.ReadLine();
        }
    }
}
