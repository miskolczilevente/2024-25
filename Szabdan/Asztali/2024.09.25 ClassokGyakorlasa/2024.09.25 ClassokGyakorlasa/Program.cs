using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace _2024._09._25_ClassokGyakorlasa
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            Fajlbeolvasas();

        }
        static void Fajlbeolvasas()
        {
            Pitypang.PitypangBeolv("pitypang.txt");

        }

        
    }
    class Feladatok
    {
        public Feladatok() 
        {
            
        }

    }

    class Pitypang
    {

        public static List<Pitypang> pitypangok = new List<Pitypang>();

        int sorszam, szobaszam, erkezes_napja, tavozas_napja, vendegek_szama;
        bool reggeli;
        string nev;

        public Pitypang(int sorszam, int szobaszam, int erkezes_napja, int tavozas_napja, int vendegek_szama, bool reggeli, string nev)
        {
            this.sorszam = sorszam;
            this.szobaszam = szobaszam;
            this.erkezes_napja = erkezes_napja;
            this.tavozas_napja = tavozas_napja;
            this.vendegek_szama = vendegek_szama;
            this.reggeli = reggeli;
            this.nev = nev;
        }

        public static void PitypangBeolv(string eleres)
        {
            StreamReader sr = new StreamReader(eleres);

            int n = Convert.ToInt32(sr.ReadLine());

            while (!sr.EndOfStream)
            {
                string[] list = sr.ReadLine().Split(' ');
                Pitypang dr = new Pitypang(Convert.ToInt32(list[0]), Convert.ToInt32(list[1]), Convert.ToInt32(list[2]), Convert.ToInt32(list[3]), Convert.ToInt32(list[4]), Convert.ToBoolean(list[5]), list[6]);
                pitypangok.Add(dr);
            }
            sr.Close();
        }
    }

}
