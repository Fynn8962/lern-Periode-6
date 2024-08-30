using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_320_4207_Linienzeichner
{
    internal class program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Zeichen: ");
             char input = Console.ReadLine().First();
            Linienzeichner Zeichner = new Linienzeichner(input);
            Console.WriteLine(Zeichner.Zeichne(10));


            // 1. Überladung
            Console.WriteLine(Zeichner.Zeichne(10, 'D'));

            // 2. Überladung
            Console.WriteLine(Zeichner.Zeichne(0.1f, 20));

            // 3. Überladung
            Console.WriteLine(Zeichner.Zeichne(0.2f, 40, '='));

        }




    }
}
