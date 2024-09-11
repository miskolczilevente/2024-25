using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_09_11_Ismetles_Matrix
{ 
    /* Készítsen egy 2d adatszerkezetet, amiben eltárol számokat!
    * A szerkezet nagyságát a felhasználótól kérje be! 
    * A számok [60,2500] közötti 20-szal oszthatóak! Egymás melletti számok különbsége (átlóra is nézve) nem lehet nagyobb 300-nál!
    * Ezek a számok egy földrajzi terület tengerszint feletti magasságai.*/

    //Induljon el az első elemtöl és megnézi az alsót és a jobbat amelyik kisebb arra megy szinezd át az utvonalatt
    internal class Program
    {
        static List<List<int>> t = new List<List<int>>();
        static Random r = new Random();

        static void Main(string[] args)
        {
            MatrixFeltolt();
            MatrixKiir();
            MatrixPath();

            Console.ReadLine();
        }

        private static void MatrixKiir()
        {
            for (int i = 0; i < t.Count; i++)
            {
                for (int j = 0; j < t[i].Count; j++)
                {
                    Console.Write(t[i][j].ToString().PadLeft(5));
                }
                Console.WriteLine();
            }
        }

        static bool MatrixFeltolt()
        {
            Console.Write("Adja meg a terület szélességét: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg a terület magasságát: ");
            int m = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                t.Add(new List<int>());
                for (int j = 0; j < m; j++)
                {
                    t.Last().Add(Szamgeneral(t, i, j));
                }
            }
            return true;
        }

        static int Szamgeneral(List<List<int>> matrix, int sor, int oszlop)
        {
            int mine = t[sor].Count>0 ? matrix[sor][oszlop-1] : 
                        sor>0? matrix[sor-1][oszlop] : r.Next(3,126)*20;
            int maxe = t[sor].Count > 0 ? matrix[sor][oszlop - 1] :
                        sor > 0 ? matrix[sor - 1][oszlop] : mine;
            if (sor>0)
                for (int i = oszlop-1; i < oszlop+2; i++)
                {
                    if (i > -1 && i < matrix[sor - 1].Count)
                    {
                        if (matrix[sor - 1][i] < mine)
                            mine = matrix[sor - 1][i];
                        if (matrix[sor - 1][i] > maxe)
                            maxe = matrix[sor - 1][i];
                    }
                }
            if(oszlop>0 && mine > matrix[sor][oszlop-1])
                mine = matrix[sor][oszlop-1];
            if(oszlop>0 && maxe < matrix[sor][oszlop-1])
                maxe = matrix[sor][oszlop-1];
            int a = maxe>359 ? (maxe - 300)/20 : 3;
            int b = mine < 2200 ? (mine + 300)/20 : 126;
            return r.Next(a > b ? b : a, a > b ? a :b) *20;
        }

        static void MatrixPath()
        {
            int x = 0;
            int y = 0;
            while (x < t.Count())
            {
                if (t[x+1][y] > t[x][y+1])
                {
                    t[x][y]
                    x++;                    
                }
            }
        }

    }
}
