using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._11._19.Szuperhos
{
    internal abstract class Bosszuallo : Szuperhos
    {

        private float szuperero;
        private bool vanEGyengessege;
        public Bosszuallo(float szuperero, bool vanEGyengessege)
        {
            this.szuperero = szuperero;
            this.vanEGyengessege = vanEGyengessege;
        }

        public bool legyoziE(Szuperhos szuperhos)
        {
            if (szuperhos.GetType() == typeof(Bosszuallo))
            {
                if (szuperhos.mekkoraAzEreje() < this.mekkoraAzEreje() && ((Bosszuallo)szuperhos).vanEGyengessege)
                {
                    return true;
                }
            }
            else if (szuperhos.GetType() == typeof(Batman)) 
            {
                if (szuperhos.mekkoraAzEreje() * 2 <= this.mekkoraAzEreje())
                {
                    return true;
                }
            }
            return false;
        }
        public float mekkoraAzEreje()
        {
            return szuperero;
        }

        public float Szuperero
        {
            get { return szuperero; }
            set { szuperero = value; }
        }
        public bool VanEGyengessege
        {
            get { return vanEGyengessege; }
            set { vanEGyengessege = value; }
        }

        public override string ToString()
        {
            return szuperero + " " + vanEGyengessege;
        }


        public abstract bool MegmentiAVilagot();
    }
}
