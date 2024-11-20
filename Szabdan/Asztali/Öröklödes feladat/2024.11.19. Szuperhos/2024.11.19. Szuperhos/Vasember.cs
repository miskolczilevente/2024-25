using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _2024._11._19.Szuperhos
{
    internal class Vasember : Bosszuallo, Milliardos
    {
        Random _random = new Random();
        public Vasember(): base (150, true) 
        {
            
        }
        public void kutyutKeszit()
        {
            this.Szuperero += _random.Next(0,11);
        }

        public override bool MegmentiAVilagot()
        {
            if (this.Szuperero > 1000)
                return true;
            return false;
        }

        public override string ToString()
        {
            return "Vasember " + base.ToString();
        }
    }
}
