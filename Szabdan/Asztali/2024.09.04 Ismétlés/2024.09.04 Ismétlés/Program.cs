using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2024._09._04_Ismétlés
{
    internal class Program
    {
        static Random r = new Random();
        static void Main(string[] args)
        {
            /* Ismétlés
             * Vezérlő szerkezetek (utasítás, elágazás, ciklus)
             * Programozási tételek
             * Metódusok (függvény, eljárás)
             * Osztályok (class)
             * Öröklödés + scope
             * Fájlbeolvasás
             */

            /*string a = "BA";
             * Console.WriteLine(convert.ToInt32(a, 16));
             * int b = 186;
             * Console.WriteLine(b.ToString("X"));
             *
             */


            f1();
            Console.ReadLine();
   
        }
        static void f1()
        {
            for (int i = 0; i < 20; i++)
            {
                string hex = general();
                Console.WriteLine(hex);
                Console.WriteLine(rgb(hex));
            }
        }

        static string rgb(string hex) {
            int szam = 0;
            

            for (int i = 0; i < 5; i += 2)
            {
                szam = 0;
                szam += (rgbalakitas(hex[i]) * 16) + rgbalakitas(hex[i + 1]);
                Console.WriteLine(szam);
            }


            return hex;
        }

        static int rgbalakitas(char hex) {
            if (Char.IsNumber(hex)) { return Convert.ToInt32(hex) -48; } else { return ((int)hex) - 55; }
        }

        static string general()
        {
            List<string> lista = new List<string>();
            for (int i = 0; i < 6; i++)
            {
                int ran = r.Next(55, 72);

                lista.Add(atalakitas(ran));
            }
            string combinedString = string.Join("", lista.ToArray());
            return combinedString;
        }

        static string atalakitas(int ran)
        {
            string adat;
            if (ran < 65)
            {
                ran = ran - 55;
                adat = Convert.ToString(ran);
            }
            else
            {
                adat = Convert.ToString(Convert.ToChar(ran));
                
            }
            return adat;
        }
    }
}
