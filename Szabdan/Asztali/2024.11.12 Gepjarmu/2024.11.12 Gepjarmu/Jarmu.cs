using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._11._12_Gepjarmu
{
    internal abstract class Jarmu
    {
        protected int aktSebesseg;
        private string rendszam;

        public Jarmu(int aktSeb, string rendsz) 
        {
            aktSebesseg = aktSeb;
            rendszam = rendsz;
        }

        public abstract bool GyorshajtottE(int sebbessegkorlat);

        public override string ToString()
        {
            return $"{rendszam} - {aktSebesseg} km/h";
        }
        

    }
}
