using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._10._22_Tesztelési_alapok
{
    /// <summary>
    /// Aosztályra vonatkozó információk megadása
    /// </summary>
    internal class Aosztaly
    {
        /// <summary>
        /// Álatlános függvény leírás
        /// </summary>
        /// <param name="a">A paraméterröl informáciok</param>
        /// <returns>Mi lesz a vissza térési érték</returns>
        public double Metodus1(int a)
        {
            return Math.Asin(Math.Abs((double)a/10000));
        }


        /// <summary>
        /// Az adott osztály szöveges megjelenítése
        /// </summary>
        /// <returns> Szöveges visszatérés </returns>
        public override string ToString()
        {
            return "Adatok kíiratása";
        }
    }
}
