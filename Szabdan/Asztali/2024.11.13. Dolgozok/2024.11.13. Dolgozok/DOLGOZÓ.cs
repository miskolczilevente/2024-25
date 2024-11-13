using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace _2024._11._13.Dolgozok
{
    internal class Dolgozo
    {
        private string nev;
        private int evek;
        private bool aktiv;
        private string allapot;

        public Dolgozo(string nev, int evek = 0, bool aktiv = true)
        {
            this.nev = nev;
            this.evek = evek;
            this.aktiv = aktiv;
        }

        public string Nev
        {
            get {return nev;}
        }
        public int Evek
        {
            get { return evek; }
        }
        public bool Aktiv
        {
            get { return aktiv; }
        }

        public void UjEv()
        {
            evek++;
        }

        public void ModositInaktiv()
        {
            aktiv = false;
        }

        public override string ToString()
        {
            return $"{nev}: {evek} éve dolgozik itt státusza: {(aktiv ? "aktív" : "inaktív")}";
        }
    }
}
