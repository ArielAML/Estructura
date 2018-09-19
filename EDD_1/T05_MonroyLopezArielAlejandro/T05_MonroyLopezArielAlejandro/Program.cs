using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace T05_MonroyLopezArielAlejandro
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch S = new Stopwatch();
            S.Start();
            Console.WriteLine("El resultado de la suma es: {0} \nTiempo: {1}", Suma(),S.Elapsed.ToString());
            S.Stop();
            Console.ReadKey();
        }

        public static double Suma()
        {
            double sum=0;
            for (int cont = 1; cont < 1000001; cont++) { sum = sum + cont; }
            return sum;
        }
    }
}
