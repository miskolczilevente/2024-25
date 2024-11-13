using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._11._12_Gepjarmu
{
    internal class Orszagut
    {
        public static List<Jarmu> jarmuvek = new List<Jarmu>();

        public static void JarmuvekJonnak(string path)
        {
            StreamReader f = new StreamReader(path);

            while (!f.EndOfStream)
            {
                string[] st = f.ReadLine().Split(';');
                if (st[0] == "robogo")
                {
                    jarmuvek.Add(new Robogo(Convert.ToInt32(st[2]), st[1], Convert.ToInt32(st[3])));
                }
                else
                {
                    jarmuvek.Add(new AudiS8(st[1], Convert.ToInt32(st[2]), st[3] == "true"));
                }
            }

            f.Close();
        }

        public static void KiketMertunkBe()
        {
            StreamWriter g = new StreamWriter("buntetes.txt");

            foreach (Jarmu jarmu in jarmuvek)
            {
                g.Write(jarmu.ToString());
                if (jarmu.GetType() == typeof(AudiS8) && jarmu.GyorshajtottE(90))
                    g.Write(" Gyorshajtott");
                if (jarmu.GetType() == typeof(Robogo) && !((Robogo)jarmu).HaladhatItt(90))
                    g.Write(" Nem haladhat ezen az úton");
                else if (((Robogo)jarmu).HaladhatItt(90))
                g.WriteLine();
            }

            g.Close(); 
        }
    }
}
