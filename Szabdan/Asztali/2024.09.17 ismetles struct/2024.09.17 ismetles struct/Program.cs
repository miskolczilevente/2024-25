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

            //Console.WriteLine($"{k1.nev} , {k1.fajta}, {k1.kor}, {k1.suly}, {k1.chip}");
            Console.WriteLine(k1.ToString());

            Kutya k2 = new Kutya("Lex", "vizsla", 3, 25, true);

            //Console.WriteLine($"{k2.nev} , {k2.fajta}, {k2.kor}, {k2.suly}, {k2.chip}");
            Console.WriteLine(k2.ToString());

            Kutya[] kutyaTomb = new Kutya[] { k1, k2 };
            //List<Kutya> kutyalista = new List<Kutya>();
            List<Kutya> kutyaLista = new List<Kutya>() { k1,k2 };

            int[] t = new int[] {0,1,2,3,4,5 };
            List<int> lista = t.ToList();
            int[] t2 = lista.ToArray();

            Kutya[] kutyatomb = kutyaLista.ToArray();

            Kutya k3 = k2;
            k3.nev = "Max";

            Console.WriteLine(k3.ToString());


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

        public string Ugat()
        {
            return "Vau-Vau";
        }

        public override string ToString()
        {
            return string.Format($"{nev}, {fajta}, {kor}, {suly}, {chip}");
        }

        


        
    }

}
