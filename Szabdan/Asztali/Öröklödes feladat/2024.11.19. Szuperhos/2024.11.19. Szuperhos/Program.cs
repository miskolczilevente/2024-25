﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._11._19.Szuperhos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vasember tony = new Vasember();

            Kepregeny.szereplok("nigga.txt");

            Kepregeny.szuperhosok();

            Console.ReadLine(); 
        }
    }
}
