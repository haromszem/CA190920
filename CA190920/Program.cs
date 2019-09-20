using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA190920
{
    class Program
    {
        static void Main(string[] args)
        {

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
            
            Console.ReadKey();
        }
    }
}
