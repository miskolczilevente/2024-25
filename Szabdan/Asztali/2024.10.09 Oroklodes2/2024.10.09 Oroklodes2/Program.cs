using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._10._09_Oroklodes2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ososztaly os = new Ososztaly(123);
            //os.x = 123;
            //Console.WriteLine(os.ToString());

            Utodosztaly utod = new Utodosztaly(543,654);
            //utod.b = 543;
            //Console.WriteLine(utod.ToString());

            Console.ReadLine();

        }
    }

    class Ososztaly
    {
        public int x;
        public void Tobbszoroz(int a) 
        {
            x *= a;
        }

        public Ososztaly(int x)
        {
            this.x = x;
        }

        public override string ToString()
        {
            return "x= " + x;
        }
    }

    class Utodosztaly : Ososztaly 
    {
        //Mezök
        public int b;

        //Konstruktor
        public Utodosztaly(int b, int x) : base(x)
        {

        }
        public void TobbszorozB(int k) 
        {
            b *= k;
        }

        public override string ToString()
        {
            return "b= " + b + "\tx= "+x;
        }
    }

}
