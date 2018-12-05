using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E6_MonroyLopezArielAlejandro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t   PROBLEMA 1\n");
            Problema1 P1 = new Problema1();
            P1.main();
            Console.Clear();
            Console.WriteLine("\t   PROBLEMA 2\n");
            Problema2 P2 = new Problema2();
            P2.main();
            Console.ReadKey();
        }
    }
}
