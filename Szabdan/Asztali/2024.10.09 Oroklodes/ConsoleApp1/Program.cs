using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kutya k = new Kutya();

            //k.ugat();

            Puli p = new Puli();
            p.Terel();

            p.ugat();

            Kutya k = p;
            k.ugat();
            //k.Terel(); //polimorfizmus miatt nem megoldható

            Console.ReadLine();
        }
    }
    class Kutya
    {
        public void ugat()
        {
            Console.WriteLine("Vau-Vau");
        }
    }

    class Puli : Kutya
    {
        public void Terel()
        {
            Console.WriteLine("Gyerünk, indulás, lusta banda!");
        }
    }
}
