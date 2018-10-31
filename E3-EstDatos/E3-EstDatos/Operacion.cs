using System;
using System.Collections;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_EstDatos
{
    public class Operacion
    {
        
        public void Principal()
        {
            Stack Lista = new Stack();
            Queue Cola = new Queue();

        }

        public void Ejercicio1()
        {
            //¿Qué valores se devuelven durante la siguiente serie de operaciones de pila,
            //si se ejecutan en una pila inicialmente vacía ?
            //push(5), push(3), pop(), push(2), push(8),
            //pop(), pop(), push(9), push(1), pop(), push(7), push(6), pop(), pop(), push(4),
            //pop(), pop()
            Stack Lista = new Stack();
            Lista.Push(5);
            Lista.Push(3);
            Console.WriteLine(Lista.Pop());
            Lista.Push(2);
            Lista.Push(8);
            Console.WriteLine(Lista.Pop());
            Console.WriteLine(Lista.Pop());
            Lista.Push(9);
            Lista.Push(1);
            Console.WriteLine(Lista.Pop());
            Lista.Push(7);
            Lista.Push(6);
            Console.WriteLine(Lista.Pop());
            Console.WriteLine(Lista.Pop());
            Lista.Push(4);
            Console.WriteLine(Lista.Pop());
            Console.WriteLine(Lista.Pop());
            Console.ReadKey();
        }

        public void Ejercicio2()
        {
            //Escriba en este metodo un modulo que pueda leer  y almacenar palabras reservadas en una lista enlazada 
            //e identificadores y literales en Otra lista enlazada.
            //Cuando el programa haya terminado de leer la entrada, mostrar
            //Los contenidos de cada lista enlazada.
            //Revise que es un Identificador y que es un literal
            string palabra;
            string[] test = {"abstract","enum", "long", "stackalloc", "as", "event","namespace","static","base","explicit","new", "string",
"bool", "extern",   "null", "struct","break","false","object","switch","byte", "finally",  "operator","this",
"case", "Fixed",   "out", "throw", "catch",    "float",   "override",  "true",
"char",    "for",   "params",  "try", "checked",  "foreach",  "private",  "typeof",
"class",   "goto",  "protected", "uint", "const",   "if",    "public", "ulong",
"continue", "implicit",    "readonly",  "unchecked", "decimal", "in", "ref", "unsafe",
"default",  "int",  "return",   "ushort", "delegate",    "interface",   "sbyte",  "using",
"do",   "internal", "sealed", "virtual", "double",   "is",   "short", "void", "else", "lock","sizeof","while"};
            LinkedList<string> palabrareservada = new LinkedList<string>();
            LinkedList<string> identificador = new LinkedList<string>();
            LinkedList<string> literales = new LinkedList<string>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Introduce palabra {0}", i + 1);
                palabra = Console.ReadLine();
                int valor;
                valor = Convert.ToInt32(palabra[0]);
                if (valor >= 65 && valor <= 122 || palabra[0] == '_')
                {
                    foreach (string item in test)
                    {
                        if (palabra == item)
                        {
                            palabrareservada.AddFirst(item);
                            goto final;
                        }
                    }
                    identificador.AddFirst(palabra);
                    final:
                    Console.Clear();
                }
                else
                {
                    literales.AddFirst(palabra);
                    Console.Clear();
                }
            }
            Console.WriteLine("Identificadores introducidos");
            foreach (var r in identificador)
            {
                Console.WriteLine(r);
            }
            Console.ReadKey();
            Console.WriteLine("Literales introducidos");
            foreach (var r in literales)
            {
                Console.WriteLine(r);
            }
            Console.ReadKey();
            Console.WriteLine("Palabras Reservadas");
            foreach (var r in palabrareservada)
            {
                Console.WriteLine(r);
            }
            Console.ReadKey();
            Console.Clear();


        }

        public void Ejercicio3()
        {
            //mida el tiempo entre Un lista ligada y una lista normal en el tiempo de ejecucion de 9876 elementos agregados.
            List<object> Lista = new List<object>();
            LinkedList<object> Ligada = new LinkedList<object>();

            Stopwatch Tiempo1 = new Stopwatch();

            Tiempo1.Start();
            for (int i = 0; i < 9875; i++)
            {
                Lista.Add(i);
            }
            Tiempo1.Stop();
            Console.WriteLine("Tiempo de la lista normal en almacenar 9876 elementos: " + Tiempo1.Elapsed.ToString());

            Stopwatch Tiempo2 = new Stopwatch();

            Tiempo2.Start();
            for (int i = 0; i < 9875; i++)
            {
                Ligada.AddLast(i);
            }
            Tiempo2.Stop();
            Console.WriteLine("Tiempo de la lista ligada en almacenar 9876 elementos: " + Tiempo2.Elapsed.ToString());

        }

        public void Ejercicio4()
        {
            // Diseñar e implementar una clase que le permita a un maestro hacer un seguimiento de las calificaciones
            // en un solo curso.Incluir métodos que calculen la nota media, la
            //calificacion más alto, y el calificacion más bajo. Escribe un programa para poner a prueba tu clase.
            //implementación. Minimo 30 Calificaciones, de 30 alumnos.

        }
        public void Ingreso()
        {
            Clase ClaC = new Clase();
            Stack<Clase> Materia = new Stack<Clase>();
            Console.Write("Ingrese el nombre del maestro: ");
            ClaC.Maestro = Console.ReadLine();
            Console.Write("Ingrese el nommbre de la materia: ");
            ClaC.NombreClase = Console.ReadLine();
            Console.Write("Ingrese cuantos alumnos quiere: ");
            int numAl = int.Parse(Console.ReadLine());
            for (int i = 0; i < numAl; i++)
            {
                Console.Write("Ingrese el nombre del alumno {0}: ", i + 1);
                ClaC.Alumno = Console.ReadLine();
                Console.Write("Ingrese la calificacion del alumno: ");
                ClaC.Calificacion = int.Parse(Console.ReadLine());
                Materia.Push(ClaC);
            }
            Mediana(Materia,numAl);
        }
        public void Mediana(Stack<Clase> pila, int NoAl)
        {
            int suma=0;
            double total;
            List<object> Cmedia = new List<object>();
            foreach (var item in pila)
            {
                suma = item.Calificacion + suma;
            }
            total = suma / NoAl;
            foreach (var item in pila)
            {
                if (item.Calificacion <(total-10) && item.Calificacion > (total + 10))
                {
                    Cmedia.Add(item);
                }
            }
        }
        public void Menor(Stack<Clase> pila)
        {
            List<object> menor = new List<object>();
            foreach (var item in pila)
            {
                menor.Add(item);
            }
            menor.Sort();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Calificaciones mas bajas: {0} {1}",menor(i));
            }
        }
        public void Mayor()
        {

        }
    }
}
