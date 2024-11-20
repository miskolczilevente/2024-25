using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._11._19.Szuperhos
{
    internal class Batman : Szuperhos, Milliardos
    {
        public float lelemenyesseg;

        public Batman(float lelemenyesseg = 100)
        {
            this.lelemenyesseg = lelemenyesseg;
            
        }

        public float mekkoraAzEreje()
        {
            return lelemenyesseg * 2;
        }

        public bool legyoziE(Szuperhos szuperhos)
        {
            if(this.lelemenyesseg > szuperhos.mekkoraAzEreje())
            {
                return true;
            }
            return false;
        }

        public void kutyutKeszit()
        {
            lelemenyesseg += 50;
        }

        public override string ToString()
        {
            return "Batman " + lelemenyesseg;
        }
    }
}
