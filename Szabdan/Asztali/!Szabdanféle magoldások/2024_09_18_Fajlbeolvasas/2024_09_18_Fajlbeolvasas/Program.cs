using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_09_18_Fajlbeolvasas
{
    internal class Program
    {
        static int[,] feladvany;
        static List<Megoldas> megoldasok = new List<Megoldas>();

        static void Main(string[] args)
        {
            //megoldas.txt, feladvany.txt
            Fajlbeolvasas1("feladvany.txt");
            Fajlbeolvasas2("megoldas.txt");

            Console.ReadLine();
        }

        private static void Fajlbeolvasas2(string path)
        {
            StreamReader f = new StreamReader(path);
            f.ReadLine();

            while (!f.EndOfStream)
            {
                megoldasok.Add(new Megoldas(f.ReadLine(), MatrixKeszit(f)));
            }

            f.Close();
        }

        private static void Fajlbeolvasas1(string path)
        {
            StreamReader f = new StreamReader(path);

            feladvany = MatrixKeszit(f);

            f.Close();
        }

        private static int[,] MatrixKeszit(StreamReader f)
        {
            int[,] t = new int[10, 10];
            for (int i = 0; i < 10; i++) {
                int[] st = Array.ConvertAll(f.ReadLine().Split(' '), Convert.ToInt32);
                for (int j = 0; j < st.Length; j++)
                    t[i, j] = st[j];
            }
            return t;
        }
    }

    struct Megoldas {
        public string nev;
        public int[,] matrix;

        public Megoldas(string nev, int[,] matrix) {
            this.nev = nev;
            this.matrix = matrix;
        }
    }
}
