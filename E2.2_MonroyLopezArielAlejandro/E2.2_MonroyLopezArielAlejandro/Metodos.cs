using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace E2._2_MonroyLopezArielAlejandro
{
    class Metodos
    {
        public void Menu()
        {
            int respuesta = 0;
            do
            {
                Console.Clear();
                Stopwatch S = new Stopwatch();
                Console.WriteLine("     ##Fibunacci##");              
                Console.Write("Que proceso desea realizar? \n\n1.- Fibunacci - Iteracion\n2.- Fibunacci - Recursividad\n3.- Salir del programa \n\n... ");
                respuesta = int.Parse(Console.ReadLine());
                switch (respuesta)
                {
                    case 1:
                        S.Start();
                        MetodoIterativo();
                        S.Stop();
                        Console.WriteLine("\nEl tiempo de ejecucion fue de: {0}",S.Elapsed.ToString());
                        break;
                    case 2:
                        S.Start();
                        MetodoRecursivo();
                        S.Stop();
                        Console.WriteLine("\nEl tiempo de ejecucion fue de: {0}", S.Elapsed.ToString());
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Porfavor ingrese solo el numero correspondiente al proceso que elija.");
                        break;
                }
                Console.ReadKey();
            }   
            while (respuesta != 1 || respuesta != 2) ;
        }


        public void MetodoIterativo()
        {
            int NumSucecion = 0, ResultadoIteracion = 0, ResultadoSecuencia=1, Secuencia=0;
            Console.Clear();
            Console.Write("Ingrese el numero de sucesiones del fibonacci: ");
            NumSucecion = int.Parse(Console.ReadLine());
            Console.WriteLine("\nLa sucecion es: ");
            for (int contador=0; contador<NumSucecion; contador++)
            { 
                if (contador == 0)
                {
                     Console.Write("0 ");
                }
                if (contador == 1)
                {
                     Console.Write("1 ");   
                }
                if (contador >1 )
                {
                    Secuencia = ResultadoIteracion + ResultadoSecuencia;
                    ResultadoIteracion = ResultadoSecuencia;
                    ResultadoSecuencia = Secuencia;
                    Console.Write("{0} ", Secuencia);
                }         
            }
        }

        public void MetodoRecursivo()
        {
            int NumSucecion = 0;
            Console.Clear();
            Console.Write("Ingrese el numero de sucesiones del fibonacci: ");
            NumSucecion = int.Parse(Console.ReadLine());
            Console.Write("El resultado de la sucecion es: \n");
            for (int contador=0; contador< NumSucecion; contador++)
            {
                Console.Write("{0} ", Recurcion(contador));
            }          
        }

        public int Recurcion(int conta)
        {
            if (conta < 2)
            {
                return conta;
            }
            else
            {
                return Recurcion(conta- 1) + Recurcion(conta - 2);
            }
        }
    }
}
