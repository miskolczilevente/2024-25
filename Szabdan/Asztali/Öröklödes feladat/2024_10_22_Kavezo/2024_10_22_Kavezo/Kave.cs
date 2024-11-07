using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2024_10_22_Kavezo
{
    internal class Kave : IArlap
    {
        //Adattag
        private bool habosE;

        //Konstruktor
        public Kave(bool habose)
        {
            habosE = habose;
        }

        public double MennyibeKerul()
        {
            return habosE ? 180 * 1.5 : 180;
        }

        public override string ToString()
        {
            //return string.Format("{0} - {1} Ft", habosE ? "Habos" : "Nem habos", MennyibeKerul());
            return string.Format($"{(habosE ? "Habos" : "Nem habos")} - {MennyibeKerul()} Ft");
        }

    }
}
