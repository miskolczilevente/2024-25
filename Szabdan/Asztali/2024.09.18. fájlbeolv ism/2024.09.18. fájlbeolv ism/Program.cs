using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2024._09._18.fájlbeolv_ism
{
    internal class Program
    {
        static List<Solutions> solutions = new List<Solutions>();
        static void Main(string[] args)
        {
            fileread();
            Console.ReadLine();
        }

        static void fileread() 
        {
            StreamReader sr = new StreamReader("megoldas.txt");
            int n = Convert.ToInt32(sr.ReadLine());
            while (sr.EndOfStream) 
            {
                Solutions solution = new Solutions();
                solution.name = sr.ReadLine();
                for (int i = 0; i < 10; i++) 
                {
                    List<int> sor = new List<int> (Convert.ToInt32(sr.ReadLine().Split(' ')));
                    for (int j = 0; j < sor.Count; j++)
                    {
                        solution.matrix[i,j] = sor[j];
                    }
                }
                solutions.Add(solution);
            }
        }

        struct Solutions
        {
            public string name;
            public int[,] matrix;

            public Solutions(string name, int[,] matrix)
            {
                this.name = name;
                this.matrix = matrix;
            }
        }
    }
}
