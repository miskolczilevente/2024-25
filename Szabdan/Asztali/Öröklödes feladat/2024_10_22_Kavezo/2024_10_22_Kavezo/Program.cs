using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_10_22_Kavezo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pogacsa p = new Pogacsa(25, 20);
            //Console.WriteLine(p.ToString());

            //Kave k = new Kave(false);
            //Console.WriteLine(k.ToString());

            Pekseg.Vasarlok("adatok.txt");
            Pekseg.etelLeltar("adatok.txt");
            List<IArlap> t = Pekseg.termekek;
            Console.WriteLine(t[0].ToString());

            Pogacsa p = (Pogacsa)t[0];
            p.Megkostol();
            Console.WriteLine(p.ToString());
            Console.WriteLine(t[0].ToString());

            Console.WriteLine(t[0].GetType());
            Console.WriteLine(t[0].GetType() == typeof(Peksutemeny));


            Console.ReadLine();
        }
    }
}
