using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_09_18_fajlbeolvasas_structban
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Megoldas> megoldasok = Megoldas.Fajlbeolvasas("megoldas.txt");


            Console.ReadLine();
        }
    }

    struct Megoldas
    {
        public string nev;
        public int[,] matrix;

        public Megoldas(string nev, int[,] matrix)
        {
            this.nev = nev;
            this.matrix = matrix;
        }

        public static List<Megoldas> Fajlbeolvasas(string path)
        {
            List<Megoldas> megoldasok = new List<Megoldas>();
            StreamReader f = new StreamReader(path);
            f.ReadLine();

            while (!f.EndOfStream)
            {
                megoldasok.Add(new Megoldas(f.ReadLine(), MatrixKeszit(f)));
            }


            f.Close();
            return megoldasok;
        }

        private static int[,] MatrixKeszit(StreamReader f)
        {
            int[,] t = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                int[] st = Array.ConvertAll(f.ReadLine().Split(' '), Convert.ToInt32);
                for (int j = 0; j < st.Length; j++)
                    t[i, j] = st[j];
            }
            return t;
        }
    }
}
