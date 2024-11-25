using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2024._11._19.Szuperhos
{
    internal class Kepregeny
    {
        static public List<Szuperhos> niggas = new List<Szuperhos> ();        
        static public void szereplok(string path)
        {
            StreamReader r = new StreamReader(path);
            while (!r.EndOfStream) 
            {
                string[] sor = r.ReadLine().Split();
                if (sor[0] == "Vasember")
                {
                    Vasember p = new Vasember();
                    for (int i = 0; i < Convert.ToInt32(sor[1]); i++)
                    {
                        p.kutyutKeszit();
                    }
                    niggas.Add(p);
                }
                else
                {
                    Batman p = new Batman();
                    for (int i = 0; i < Convert.ToInt32(sor[1]); i++)
                    {
                        p.kutyutKeszit();
                    }
                    niggas.Add(p);
                }
                

                
            }

            r.Close();
        }


        static public void szuperhosok()
        {
            foreach (var nigga in niggas)
            {
                Console.WriteLine(nigga.ToString()); 
            }
        } 
    }
}
