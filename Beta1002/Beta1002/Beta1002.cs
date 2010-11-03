using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Beta1002
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add using System.IO;

            string line = null;
            int teljari = 0; 

            List<int> numbers = new List<int>();

            using(StreamReader reader = new StreamReader("tolur.txt")) //Tolur er lina af tolum med bili a milli
            {
                line = reader.ReadLine(); //Line verdur linan af tolunum
            }

            string[] lines = line.Split(' '); //By til fylki sem tekur ut oll bilin og setur hverja tolu i sitt holf

            for (int i = 0; i < lines.Length; i++)
            {
                numbers.Add(Convert.ToInt32(lines[i].ToString())); //Set tolurnar ur string fylkinu fyrir ofan i numbers 
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                teljari++; 
                Console.Write("{0}: {1}   ", teljari, numbers[i]); //Teljari synir numer linu, og numbers skrifar toluna

                for (int x = 0; x < numbers[i]; x++) //Keyrir a medan x er minna en talan sem verid er ad nota
                {
                    Console.Write("*"); //Baetir alltaf stjornu vid
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
