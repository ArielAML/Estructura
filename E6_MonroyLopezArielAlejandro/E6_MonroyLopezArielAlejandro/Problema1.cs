using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E6_MonroyLopezArielAlejandro
{
    public class Problema1
    {
        public void main()
        {
            int nNumeros = 0;
            string numero;
            int[] vector;

            Console.Write("Ingrese cuantos numeros quiere ingresar: ");
            nNumeros = int.Parse(Console.ReadLine());
            vector = new int[nNumeros];
            for (int i = 0; i < nNumeros; i++)
            {
                Console.Write("Ingrese un numero al vector que solo tenga los caracteres {0, 1 y 2}: ");
                numero = Console.ReadLine();
                if (numero.Contains("3") || numero.Contains("4") || numero.Contains("5") || numero.Contains("6") || numero.Contains("7") || numero.Contains("8") || numero.Contains("9"))
                {
                    Console.Write("El numero no es valido en este problema, intentelo de nuevo");
                    Console.ReadKey();
                    Console.Clear();
                    i--;
                }
                else
                {
                    vector[i] = int.Parse(numero);
                }
            }
            Console.Clear();
            Console.WriteLine("El ordenamiento original es: ");
            foreach (int item in vector)
            {
                Console.Write(" " + item);
            }
            BubbleSort(vector, nNumeros);
            Console.ReadKey();
        }
        public void BubbleSort(int[]arreglo, int lim)
        {
            int aux;
            for (int i = 0; i < lim-1; i++)
            {
                for (int j = 0; j < lim - 1; j++)
                {
                    if (arreglo[j] > arreglo[j+1])
                    {
                        aux = arreglo[j];
                        arreglo[j] = arreglo[j+1];
                        arreglo[j+1] = aux;
                    }
                }
            }
            Console.WriteLine("\nEl vector ordenado es: ");
            foreach (int item in arreglo)
            {
                Console.Write(" " + item);
            }
        }
    }
}

