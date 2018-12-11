using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_U6_MonroyLopezArielAlejandro
{
    class Program
    {
        //Este metodo de busqueda es util para encontrar valores dentro de un arreglo ordenado,
        //Lo que hace es buscar iniciando por la mitad del arreglo, dependiendo si el numero es mayor
        //o menor, se delimita a la mitad superior o inferior del arreglo para repetir el proceso y asi encontrar 
        //el valor deseado.

        static void Main(string[] args)
        {
            Ejemplo1 E1 = new Ejemplo1();
            E1.main1();
            Console.ReadKey();
            Console.Clear();
            Ejemplo2 E2 = new Ejemplo2();
            E2.main2();
            Console.ReadKey();
        }
    }
}
