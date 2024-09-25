using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._09._25_StructVSClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoStruct astruct = new AutoStruct(1600);
            AutoClass aclass = new AutoClass(1500);

            Console.WriteLine("struct: " + astruct.hut);
            Console.WriteLine("class: " + aclass.hut);


            ValtoztatStruct(astruct);
            ValtoztatClass(aclass);

            Console.WriteLine("struct: " + astruct.hut);
            Console.WriteLine("class: " + aclass.hut);

            ValtoztatStruct(ref astruct);

            Console.WriteLine("struct: " + astruct.hut);

            Console.WriteLine("struct cím átadással: " + astruct.hut);

            Console.ReadLine();
        }

        static void ValtoztatStruct(AutoStruct astruct)
        {
            astruct.hut = 0;
        }

        static void ValtoztatStruct(ref AutoStruct astruct)
        {
            astruct.hut = 0;
        }
        static void ValtoztatClass(AutoClass aclass)
        {
            aclass.hut = 0;
        }

    }
    struct AutoStruct
    {
        public int hut; //hengerűrtartalom

        public AutoStruct(int hut)
        {
            this.hut = hut;
        }
    }

    class AutoClass
    {
        public int hut; //hengerűrtartalom

        public AutoClass(int hut)
        {
            this.hut = hut;
        }
    }
}
