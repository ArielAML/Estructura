using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace P1_U2_MonroyLopezArielAlejandro
{
    class Program
    {
        static void Main(string[] args)
        {
            int reinicio = 0;
            do
            {
                Menu();
                Console.Write("Desea reiniciar el programa?(Presione '1'): ");
                reinicio = int.Parse(Console.ReadLine());
            }
            while (reinicio == 1);

        }
        public static void MetodoFor()
        {
            int resultado = 1;
            for (int contador = 1; contador < 7; contador++)
            {
                resultado = resultado * contador;
            }
            
            Stopwatch SW = new Stopwatch();
            SW.Start();
            Console.WriteLine("El resultado del vectorial de 6 es: {0}", resultado);
            SW.Stop();
            Console.WriteLine("El tiempo de ejecucion fue de: {0}", SW.Elapsed.ToString());
        }

        public static void MetodoRecursividad()
        {
            int numero = 6;
            Stopwatch SW = new Stopwatch();
            SW.Start();
            Console.WriteLine("El resultado del vectorial de 6 es: {0}", Recurcion(numero));
            SW.Stop();
            Console.WriteLine("El tiempo de ejecucion fue de: {0}", SW.Elapsed.ToString());
        }

        public static int Recurcion(int numero)
        {     
            if (numero == 0)
            {
                return 1;
            }
            else
            {
                return numero * Recurcion(numero - 1);
            }
        }

        public static void Menu()
        {
            int Respuesta = 0;
            Console.Write("Quiere entras al programa con For o recursividad? \nFor (1) \nRecursividad (2)\n ..... ");
            Respuesta = int.Parse(Console.ReadLine());
            switch (Respuesta)
            {
                case 1:
                    MetodoFor();
                    break;
                case 2:
                    MetodoRecursividad();
                    break;
                default:
                    Console.WriteLine("El valor ingresado es invalido");
                    break;
            }
        }
    }
}
