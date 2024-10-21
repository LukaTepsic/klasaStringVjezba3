using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaStringVjezba3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite niz znakova: ");
            string unos = Console.ReadLine();

            string sVelika = unos.ToUpper();
            string sMala = unos.ToLower();
            string sPrvaTri = unos.Substring(0, 3);
            string sZadnjihPet = unos.Length >= 5 ? unos.Substring(unos.Length - 5) : unos;
            string s8_11 = (unos.Length >= 11) ? unos.Substring(7, 4) : "";

            Console.WriteLine($"Velika slova: {sVelika}");
            Console.WriteLine($"Mala slova: {sMala}");
            Console.WriteLine($"Prva tri znaka: {sPrvaTri}");
            Console.WriteLine($"Zadnjih pet znakova: {sZadnjihPet}");
            Console.WriteLine($"Od 8. do 11. znaka: {s8_11}");
            Console.ReadKey();
        }
    }
}
