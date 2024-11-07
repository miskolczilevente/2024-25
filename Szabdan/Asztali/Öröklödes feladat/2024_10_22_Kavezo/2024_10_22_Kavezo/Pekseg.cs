using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_10_22_Kavezo
{
    internal class Pekseg
    {
        //Adattagok
        public static List<IArlap> termekek = new List<IArlap>();


        //Konstruktor

        //Metódusok
        public static void Vasarlok(string path)
        {
            StreamReader f = new StreamReader(path);

            while (!f.EndOfStream)
            {
                string[] st = f.ReadLine().Split(' ');
                //if (st.Length == 2)
                if (st[0] == "Kave")
                    termekek.Add(new Kave(st[1] == "habos"));
                else
                    termekek.Add(new Pogacsa(Convert.ToInt16(st[1]), Convert.ToInt16(st[2])));
            }

            f.Close();
        }

        public static void etelLeltar(string path)
        {
            StreamReader r = new StreamReader(path);
            StreamWriter f = new StreamWriter("leltar.txt");

            while (!r.EndOfStream)
            {
                string[] st = r.ReadLine().Split(' ');
                if (st[0] == "Pogacsa")
                {
                    f.WriteLine($"{st[0]} {st[1]} {st[2]}");
                }
            }

            r.Close();
            f.Close();
        }

    }
}
