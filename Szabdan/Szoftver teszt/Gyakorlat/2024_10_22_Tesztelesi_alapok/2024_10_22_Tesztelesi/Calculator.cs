using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_10_22_Tesztelesi
{
    internal class Calculator
    {
        //Összeadás
        public int Add(int a, int b) {  return a + b; }

        //Kivonás
        public int Substract(int a, int b) {return a - b; }

        //Szorzás
        public int Multiply(int a, int b) {return a*b;}

        //Osztás
        public int Divide(int a, int b) 
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Nem lehet nullával osztani");
            }
            return a/b;
        }
    }
}
