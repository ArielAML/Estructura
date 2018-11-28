using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5_2_MonroyLopezArielAlejandro
{
    public class QuickSort
    {
        int longitud; //Propiedad para determinar la longitud del vector (este dato es solo necesario en el metodo mostrar)
        double[] vector;//Donde se almacenan los numeros a ordenar

        public QuickSort(double[] arreglo, int longi) //Metodo constructor
        {
            vector = arreglo;
            longitud = longi;
        }

        public void quickso(double[] arreglo, int primer, int ultimo)
            //Metodo recursivo que recive el vector original y modifica el orden de los numeros segun las condiciones
        {
            int menor = primer;
            int mayor = ultimo;
            double pivote = arreglo[(primer + ultimo) / 2];
            double auxiliar;

            do //mientras que el valor menor sea menos que el valor mayor, se acomodaran los datos del arreglo
            {
                while (arreglo[menor] < pivote) menor++;
                while (arreglo[mayor] > pivote) mayor--;
                if (menor <= mayor)
                {
                    auxiliar = arreglo[mayor];
                    arreglo[mayor] = arreglo[menor];
                    arreglo[menor] = auxiliar;
                    menor++;
                    mayor--;
                }
            } while (menor <= mayor);
            if (primer < mayor) quickso(arreglo, primer, mayor); //si el numero menor original es mas bajo a mayor(valor modificado en el metodo), se hace recursividad para reordenamiento
            if (ultimo > menor) quickso(arreglo, menor, ultimo); //Si el numero mayor original es mas alto a menor(valor modificado en el metodo), se hace recursividad para reordenamiento
        }

        public void mostrar()
        {
            Console.Clear();
            for (int i = 0; i < longitud; i++)
            {
                Console.Write(" " + vector[i] + " => "); //Muestra los valores ya ordenados dentro del vector
            }
            Console.ReadLine();
        }
    }
}
