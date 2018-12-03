using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace P1_U6_MonroyLopezArielAlejandro
{
    class Program
    {
        //La busqueda secuencial funciona en base de un ciclo donde se busca determinado dato dentro de un array y dependiendo
        //de su lugar en el array, devuelve la posicion dentro de este.

        static void Main(string[] args)
        {
            Ejemplo1 Ej1 = new Ejemplo1();
            Ejemplo2 Ej2 = new Ejemplo2();
            Ej1.MostrarEj1();
            Console.ReadKey();
            Console.Clear();
            Ej2.MostrarEj2();
            Console.ReadKey();
        }
    }
}
