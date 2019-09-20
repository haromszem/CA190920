using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA190920
{
    class Program
    {
        static Random r = new Random();
        static void Main(string[] args)
        {
            Random r = new Random();


            Console.WriteLine("Szia, hogy hívnak?");
            var nev= Console.ReadLine();
            Console.WriteLine("Milyen szép név az hogy {0} UwU",nev);
            Console.WriteLine("Szeretsz programozni?");
            var valasz = Console.ReadLine();
            if (valasz == "igen")
            {
                Console.WriteLine("Akkor jó barátok leszünk!");

            }
            else
            {
                Console.WriteLine("-szomorú smile-");
                Console.WriteLine("Viszlát...");
            }
            Console.WriteLine("Hallod\nNesze itt van 100 csillag");
            for (int i = 0; i < 100; i++)
            {
                Console.SetCursorPosition(r.Next(Console.WindowWidth),r.Next(Console.WindowHeight));
                Console.ForegroundColor = (ConsoleColor)r.Next(0, 50);
                Console.Write("*");

            }
            Console.ReadKey();
        }
    }
}
