using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _2024._12._10_DatumIdo
{
    internal class DatumIdo
    {
        int ev, honap, nap, ora, perc, masodperc;

        public DatumIdo(string datum)
        {
            char elvalaszto = '.';
            int i = 0;
            while (i < datum.Length || !Char.IsLetterOrDigit(datum[i]))
            {
                if (!Char.IsLetterOrDigit(datum[i]))
                {
                    elvalaszto = datum[i];
                }
                i++;
            }
            


            string[] st = datum.Split(elvalaszto);
            this.ev = Convert.ToInt32(st[0]);
            this.honap = Convert.ToInt32(st[1]);
            this.nap = Convert.ToInt32(st[2]);
        }

        public DatumIdo(int ora, int perc, int masodperc) 
        {
            this.ora = ora;
            this.perc = perc;   
            this.masodperc = masodperc;
        }

        public int DatumKulonbsegEv(string datum)
        {
            int kulonbseg = 0;
            string[] st = datum.Split('.');
            int[] it = {Convert.ToInt32(st[0]), Convert.ToInt32(st[1]), Convert.ToInt32(st[2])};
            
            kulonbseg += Math.Abs(this.ev - it[0]);
            if (it[1] < this.honap || it[1] == this.honap && it[2] < this.nap)
            {
                kulonbseg--;
            }
            return kulonbseg;
        }
        
        public bool KorabbanvanE(int ora, int perc, int masodperc)
        {
            if(this.ora < ora ||
                this.ora == ora && this.perc < perc ||
                this.ora == ora && this.perc == perc && this.masodperc < masodperc)
            {
                return true;
            }
            return false;
        }
    }
}
