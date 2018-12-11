using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_U6_MonroyLopezArielAlejandro
{
    public class Ejemplo2
    {
        public void main2()
        {
            Console.WriteLine("\t\tEjemplo 2 de busqueda binaria\n\nPrograma que genera 6 numeros del 1 al 10\n");

            int[] arreglo = new int[] {1,3,6, 8, 9, 10};  //Genero un arreglo predeterminado
            int limMin = 0; //variable que contiene el limite inferior del arreglo
            int limMax = arreglo.Max(); //variable que contiene el limite superior del arreglo
            int indiceBusqueda = 0; //variable con la cual se buscara el valor deseado
            int dato;//dato que se busca dentro del arreglo
            bool encontrado = false;//variable para mostrar mensaje en caso de encontrar o no el dato

            Console.Write("Ingresa un numero del 1 al 10 que quieras buscar en el array: ");
            dato = int.Parse(Console.ReadLine());

            int contador=0;
            foreach (int item in arreglo)
            {
                Console.WriteLine("{0}.- {1}", contador, item);
                contador++;
            }

            while (limMin <= limMax && encontrado == false) //mientras el limite minimo sea menor o igual al limite mayor, y que ademas aun no se haya encontrado el dato buscado...
            {
                indiceBusqueda = (limMin + limMax) / 2; //se suma el valor del limite minimo que delimita la busqueda mas el limite mayor y se divide entre 2 para tener una posicion en el array

                if (arreglo[indiceBusqueda] == dato) //Si la posicion donde se busco el dato es correcta, se cambia el bool a verdadero
                {
                    encontrado = true;
                }
                else if (arreglo[indiceBusqueda] > dato) //Si la posicion donde se busco el dato es mayor al dato que se busca, se reduce el limite mayor
                {
                    limMax = indiceBusqueda - 1;
                }
                else //Si la posicion donde se busco el dato es menor al dato que se busca, se incrementa el limite menor
                {
                    limMin = indiceBusqueda + 1;
                }
            }

            //Segun la variable booleana, si es verdadero, se encontro el dato, si no, no se encontro (vaya la redundancia)
            if (encontrado == true)
                Console.WriteLine("El numero {0} que se busco, esta en la posicion {1} del array", dato, indiceBusqueda);
            else
                Console.WriteLine("El numero {0} que se busco, no se encuentra en el array",dato);
        }
    }
}
