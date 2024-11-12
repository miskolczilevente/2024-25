using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._11._12_Gepjarmu
{
    internal class Robogo : Jarmu, IKisGepjarmu
    {
        int maxSebesseg;

        public Robogo(int aktSeb, string rendsz, int maxSeb): base(aktSeb, rendsz)
        {
            maxSebesseg = maxSeb;
        }

        public override bool GyorshajtottE(int maxSeb)
        {
            return aktSebesseg > maxSeb;
        }

        public bool HaladhatItt(int maxSeb)
        {
            return maxSebesseg <= maxSeb;
        }

        public override string ToString()
        {
            return "Robogo: "+base.ToString();
        }
    }
}
