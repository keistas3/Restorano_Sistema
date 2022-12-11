using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Restorano_Sistema
{
    public class DrinksRepository
    {
        private List<Drinks> Drink { get; set; } = new List<Drinks>();

        static void Main(string[] args)
        {
            // Store the path of the textfile in your system
            string file = @"C:\desktop.senas.pc\pHp\CodeAcademy mokymai\Pamokos\Csharp\Egzaminas\02\Restorano_Sistema\drinks.txt";

            // To read a text file line by line
            if (File.Exists(file))
            {
                // Store each line in array of strings
                string[] lines = File.ReadAllLines(file);

                foreach (string ln in lines)
                    Console.WriteLine(ln);
            }
            Console.WriteLine();

        }

    }
}

