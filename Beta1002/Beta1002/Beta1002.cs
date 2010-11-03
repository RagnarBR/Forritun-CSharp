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
            int teljari = 0; //Ekki notadur enntha

            List<int> numbers = new List<int>();

            using(StreamReader reader = new StreamReader("tolur.txt"))
            {
                line = reader.ReadLine();
            }

            for (int i = 0; i < line.Length; i++)
            {
                if (line != " ") //tolur.txt inniheldur linu af tolum med billi a milli
                {
                    numbers.Add(Convert.ToInt32(line[i].ToString())); //Aetladi ad setja tolurnar i thetta
                }
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]); //Skrifa ut listann
            }
            Console.ReadLine();
        }
    }
}
