using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_1_MonroyLopezArielAlejandro
{
    class Program
    {
        static void Main(string[] args)
        {
            Grafo a = new Grafo(6);
            a.integrarRuta(5, 3);
            a.integrarRuta(3, 2);
            a.integrarRuta(2, 1);
            a.rutaInicioAFin(5);
            Console.ReadKey();
            Grafo b = new Grafo(7);
            b.integrarRuta(6, 3);
            b.integrarRuta(3, 2);
            b.integrarRuta(2, 0);
            b.rutaInicioAFin(6);
            Console.ReadKey();
            Grafo c = new Grafo(5);
            c.integrarRuta(4, 3);
            c.integrarRuta(3, 2);
            c.integrarRuta(2, 0);
            c.rutaInicioAFin(4);
            Console.ReadKey();
            Grafo d = new Grafo(7);
            d.integrarRuta(2, 3);
            d.integrarRuta(3, 6);
            d.rutaInicioAFin(2);
            Console.ReadKey();
        }
    }
}
