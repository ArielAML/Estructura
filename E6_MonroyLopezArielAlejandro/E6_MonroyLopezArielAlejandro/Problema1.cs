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
            int nNumeros = 0;//Numeros que almacena el vector
            string numero; //numero que ingresa el usuario, es tipo string para poder leer su contenido y hacer excepciones
            int[] vector; //vector en el que se almacenaran los numeros

            Console.Write("Ingrese cuantos numeros quiere ingresar: ");
            nNumeros = int.Parse(Console.ReadLine());
            vector = new int[nNumeros];
            for (int i = 0; i < nNumeros; i++) //Ciclo que pide ingresar un numero el numero de veces que el usuario ingreso
            {
                Console.Write("Ingrese un numero al vector que solo tenga los caracteres {0, 1 y 2}: ");
                numero = Console.ReadLine();
                if (numero.Contains("3") || numero.Contains("4") || numero.Contains("5") || numero.Contains("6") || numero.Contains("7") || numero.Contains("8") || numero.Contains("9"))//condicion para que solo se acepten numeros con 0, 1 y 2
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
            foreach (int item in vector) //foreach que muestra los valores que ingreso el usuario
            {
                Console.Write(" " + item);
            }
            BubbleSort(vector, nNumeros);
            Console.ReadKey();
        }
        public void BubbleSort(int[]arreglo, int lim) //Metodo para acomodar el vector
        {
            int aux; //,variable auxiliar
            for (int i = 0; i < lim-1; i++) //for para comparacion de las primeras posiciones
            {
                for (int j = 0; j < lim - 1; j++) //for para comparacion del resto de numeros con las primeras posiciones
                {
                    if (arreglo[j] > arreglo[j+1]) //Si el numero de la posicion j es mayor al de j+1, se cambian de lugares
                    {
                        aux = arreglo[j];
                        arreglo[j] = arreglo[j+1];
                        arreglo[j+1] = aux;
                    }
                }
            }
            Console.WriteLine("\nEl vector ordenado es: ");
            foreach (int item in arreglo) //foreach para mostrar el vector ya ordenado
            {
                Console.Write(" " + item);
            }
        }
    }
}

