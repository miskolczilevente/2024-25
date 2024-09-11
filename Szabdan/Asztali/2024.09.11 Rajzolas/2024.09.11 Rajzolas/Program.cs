using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._09._11_Rajzolas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.CursorVisible = false;

            int x = 0;
            int y = 0;

            Console.SetCursorPosition(x, y);
            Console.Write("*");

            ConsoleKeyInfo c;

            c = Console.ReadKey();

            do {
                c = Console.ReadKey(true);

                switch (c.Key)
                {
                    case ConsoleKey.RightArrow:
                        x++; break;
                    case ConsoleKey.LeftArrow:
                        x--; break;
                    case ConsoleKey.DownArrow:
                        y++; break;
                    case ConsoleKey.UpArrow:
                        y--; break;

                }

                Console.SetCursorPosition(x, y);
                Console.Write("*");


            } while (c.Key != ConsoleKey.Escape);


            Console.ReadLine();

        }
    }
}
