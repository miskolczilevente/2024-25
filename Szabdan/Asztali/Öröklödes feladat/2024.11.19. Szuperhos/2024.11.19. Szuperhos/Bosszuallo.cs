using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._11._19.Szuperhos
{
    internal abstract class Bosszuallo : Szuperhos
    {
        public bool legyoziE(Szuperhos szuperhos)
        {
            if (szuperhos.GetType() == typeof(Bosszuallo))
            {
                if (szuperhos.mekkoraAzEreje() < this.mekkoraAzEreje() && ((Bosszuallo)szuperhos).vanEGyengessege)
                {
                    return true;
                }
            }
            else if () 
            {
                
            }
            return false;
        }
        public float mekkoraAzEreje()
        {
            return szuperero;
        }

        private float szuperero;
        private bool vanEGyengessege;

        public float Sz

        public Bosszuallo(int szuperero, bool vanEGyengessege) 
        {
            this.szuperero = szuperero;
            this.vanEGyengessege = vanEGyengessege;
        }

        public abstract bool MegmentiAVilagot();
    }
}
