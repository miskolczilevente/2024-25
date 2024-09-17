using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._09._17_ismetles_struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kutya k1 = new Kutya();
            k1.fajta = "Puli";
            k1.nev = "Buksi";

            Console.WriteLine($"{k1.nev} , {k1.fajta}, {k1.kor}, {k1.suly}, {k1.chip}");

            Kutya k2 = new Kutya("Lex", "vizsla", 3, 25, true);



            Console.ReadLine();
        }
    }

    struct Kutya
    {
        // Mezők, tulajdonságok
        public string nev, fajta;
        public int kor, suly;
        public bool chip;

        // Konstruktor
        public Kutya(string nev, string fajta, int kor, int suly, bool chip)
        {
            this.nev = nev;
            this.fajta = fajta;
            this.kor = kor;
            this.suly = suly;
            this.chip = chip;
        }


        // Metódusok
    }

}
