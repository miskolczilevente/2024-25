using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._09._11_Ismétlés_mátrix
{
    internal class Program
    {
        static int x;
        static int y;
        static int[,] matrix; 
        static Random r = new Random();
        static void Main(string[] args)
        {

            matrixSize();
            
            generate(x, y);

            Print2DArray();

            Console.ReadLine();
        }

        static void matrixSize()
        {
            Console.Write("Adja meg a matrix nagyságát: \nx: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y: ");
            y = Convert.ToInt32(Console.ReadLine());

            matrix = new int[x, y];
            
        }

        static void generate(int x, int y)
        {
            for (int i = 0; i < x; i++) {
                for (int j = 0; j < y; j++) {
                    matrix[i,j] = check(i, j);
                }
            }
        }

        static void Print2DArray()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static int numbergenerate(int min, int max) 
        {

            int rannumber;
            do
            {
                rannumber = r.Next(min, max);
            } while (rannumber % 20 != 0 && !(50 < rannumber) && !(rannumber < 2500));


            return rannumber;
        }

        static int check(int x, int y)
        {
            int max = 2500;
            int min = 10000;
            for (int i = x-1; i < x+1; i++) 
            {
                for (int j = y-1; j < y+1; j++) 
                {
                    if (matrix[x,y] != matrix[i,j] && (-1 < i && i < matrix.GetLength(0)) && (-1 < j && j < matrix.GetLength(1)))
                    {
                        min = matrix[i,j];
                    }
                    
                }
            }
            return numbergenerate(min, max);

        }
    }
}
