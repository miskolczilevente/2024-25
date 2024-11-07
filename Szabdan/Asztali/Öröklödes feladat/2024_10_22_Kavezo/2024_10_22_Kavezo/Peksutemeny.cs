using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_10_22_Kavezo
{
    internal abstract class Peksutemeny : IArlap
    {
        //Adattagok
        protected double mennyiseg;
        private double alapar;


        //Konstruktor
        public Peksutemeny(double alapar, double mennyiseg)
        {
            this.mennyiseg = mennyiseg;
            this.alapar = alapar;
        }

        //metódusok
        public abstract void Megkostol();

        public double MennyibeKerul()
        {
            return alapar * mennyiseg;
        }

        public override string ToString()
        {
            return $"{mennyiseg} db - {MennyibeKerul()} Ft";
        }
    }
}
