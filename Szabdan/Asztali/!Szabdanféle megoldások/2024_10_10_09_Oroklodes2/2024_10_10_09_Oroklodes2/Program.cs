using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2024_10_10_09_Oroklodes2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ososztaly os = new Ososztaly();
            os.x = 123;
            Console.WriteLine(os.ToString());

            Utodosztaly ut = new Utodosztaly();
            ut.b = 543;
            Console.WriteLine(ut.ToString());

            Console.ReadLine();


        }
    }

    class Ososztaly {
        public int x;
        protected int y;

        public void TobbszorozX(int a) {
            x *= a;
        }

        public override string ToString() { 
            return "x = "+x;
        }
    }

    class Utodosztaly : Ososztaly {
        public int b;

        public void TobbszorozB(int k) {
            b *= k;
        }

        public override string ToString() { 
            return "b = "+ b+"\tx = "+x+"\ty = "+y;
        }
    }

    class Osztaly {
        public void Lathatosag()
        {
            Utodosztaly u = new Utodosztaly();
            //u.y; - nem elérhető, csak öröklődéssel

        }
    }

}
