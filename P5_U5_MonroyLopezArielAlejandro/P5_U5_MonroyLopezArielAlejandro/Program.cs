using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5_U5_MonroyLopezArielAlejandro
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n1 = new int[] { 3, 6, 9, 5, 1, 4, 7, 2, 1, 3 }; //Se crea el vector original
            Radix R1 = new Radix(n1); //Se instancia la clase
            Console.WriteLine("Sin ordenar: ");
            R1.Mostrar(n1); //Se manda a llamar al metodo para mostrar los numeros dentro del vector original
            Console.WriteLine("\nOrdenados: ");
            R1.RadixSort(n1); //Ordena e imprime de forma ordenada los numeros que estaban en el vector
            Console.ReadKey();

            Console.Clear(); //Se limpia la pantalla
            int[] n2 = new int[] { 8, 3, 9, 3, 11, 7, 1, 27, 12 };//Se crea el vector original
            Radix R2 = new Radix(n2);//Se instancia la clase
            Console.WriteLine("Sin ordenar: ");
            R2.Mostrar(n2);//Se manda a llamar al metodo para mostrar los numeros dentro del vector original
            Console.WriteLine("\nOrdenados: ");
            R2.RadixSort(n2);//Ordena e imprime de forma ordenada los numeros que estaban en el vector
            Console.ReadKey();

            Console.Clear();//Se limpia la pantalla
            int[] n3 = new int[] { 10, 40, 36, 5, 24, 2, 5, 8 };//Se crea el vector original
            Radix R3 = new Radix(n3);//Se instancia la clase
            Console.WriteLine("Sin ordenar: ");
            R3.Mostrar(n3);//Se manda a llamar al metodo para mostrar los numeros dentro del vector original
            Console.WriteLine("\nOrdenados: ");
            R3.RadixSort(n3);//Ordena e imprime de forma ordenada los numeros que estaban en el vector
            Console.ReadKey();

            Console.Clear();//Se limpia la pantalla
            int[] n4 = new int[] { 55, 42, 0, -3, 0, -1, 2, 4, 7 };//Se crea el vector original
            Radix R4 = new Radix(n4);//Se instancia la clase
            Console.WriteLine("Sin ordenar: ");
            R4.Mostrar(n4);//Se manda a llamar al metodo para mostrar los numeros dentro del vector original
            Console.WriteLine("\nOrdenados: ");
            R4.RadixSort(n4);//Ordena e imprime de forma ordenada los numeros que estaban en el vector
            Console.ReadKey();

            Console.Clear();//Se limpia la pantalla
            int[] n5 = new int[] { 25, 108, 1024, 12, 351, 251, 39 };//Se crea el vector original
            Radix R5 = new Radix(n5);//Se instancia la clase
            Console.WriteLine("Sin ordenar: ");
            R5.Mostrar(n5);//Se manda a llamar al metodo para mostrar los numeros dentro del vector original
            Console.WriteLine("\nOrdenados: ");
            R5.RadixSort(n5);//Ordena e imprime de forma ordenada los numeros que estaban en el vector
            Console.ReadKey();
        }
    }
}
