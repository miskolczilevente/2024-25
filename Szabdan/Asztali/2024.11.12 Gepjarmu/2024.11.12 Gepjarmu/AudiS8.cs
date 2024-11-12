using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._11._12_Gepjarmu
{
    internal class AudiS8:Jarmu
    {
        public bool lezerBlokkolo;

        public AudiS8(string rendsz, int aktSeb, bool lezer):base(aktSeb,rendsz)
        {
            lezerBlokkolo = lezer;
        }

        public override bool GyorshajtottE(int sebbessegkorlat)
        {
            return  lezerBlokkolo ? false : aktSebesseg > sebbessegkorlat;
        }

        public override string ToString()
        {
            return "Audi: "+base.ToString();
        }
    }
}
