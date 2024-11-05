using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _2024_10_22_Tesztelesi
{ 
    /// <summary>
    /// Aosztályra vonatkozó információk megadása
    /// </summary>
    internal class Aosztaly
    {
        /// <summary>
        /// Álatlános függvény leírás
        /// </summary>
        /// <param name="a">A paraméterről információk</param>
        /// <returns>Mi lesz a visszatérési érték</returns>
        public double Metodus1(int a)
        {
            return Math.Asin(Math.Abs((double)a / 10000));
        }

        /// <summary>
        /// Két számot oszt el egymással
        /// </summary>
        /// <param name="osztando">Az osztandó szám</param>
        /// <param name="oszto">Az osztó szám</param>
        /// <returns>A két szám hányadosa</returns>

        public int Osztas(int osztando, int oszto)
        {
            return osztando / oszto;
        }
        // Hatványozás - algoritmussal

        public int Hatvanyozas(int alap, int kitevo)
        {
            int eredmeny = alap;
            if (kitevo == 0)
            {
                return 1;
            }
            else
            {
                while (1 < kitevo)
                {
                    eredmeny *= alap;
                    kitevo--;
                }
            }
            
            return eredmeny;
        }
        



        /// <summary>
        /// Az adott osztály szöveges megjelenítése
        /// </summary>
        /// <returns> Szöveges visszatérés </returns>
        public override string ToString()
        {
            return "Adatok kiíratása";
        }

    }
}
