using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_EstDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            Operacion test = new Operacion();
            test.Ejercicio1();
            Console.ReadKey();
            Console.Clear();
            test.Ejercicio2();
            Console.ReadKey();
            Console.Clear();
            test.Ejercicio3();
            Console.ReadKey();
            Console.Clear();
            test.Ejercicio4();
            Console.ReadKey();
        }
    }
}
