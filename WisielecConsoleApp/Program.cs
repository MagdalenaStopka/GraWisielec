using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogikaGry;
namespace WisielecConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gra w wisielca");

            Gra g = new Gra(); // zosta³ utworzony obiekt i wylosowane s³owo do odgadniecia
            Console.WriteLine(g.AktualnyWzorzec);
            Console.WriteLine(g.AktualnyWzorzec);
            Console.WriteLine(g.StanGry);
            // czy jest litera k
            Console.WriteLine("Czy jest k?");
            g.CzyJest('k');    
            Console.WriteLine(g.StanGry);
            Console.WriteLine(g.AktualnyWzorzec);



            g.CzyJest('m');
            Console.WriteLine("Czy jest m?");
            Console.WriteLine(g.StanGry);
            Console.WriteLine(g.AktualnyWzorzec);

            Console.ReadKey();
            // przygotuj obrazki na jutro 50 x 50 pixeli format jpg
        }

    }
}
