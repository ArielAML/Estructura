using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_U6_MonroyLopezArielAlejandro
{
    public class Ejemplo1
    {
         

        public void main1()
        {
            Console.WriteLine("\t\tEjemplo 1 de busqueda binaria\n\n" +
                "Un profesor busca a uno de sus alumnos, ya que no ha entrado a clase y quiere llamar\n" +
                "a su tutor para notificarle sobre el joven, sin embargo, tropezo y revolvio sus listas,\n" +
                "ahora tiene que ordenar las listas segun el numero de grupo y ubicar en cual esta el joven\n");
            
            int[] arreglo = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; //Genero un arreglo predeterminado
            int limMin = 0; //variable que contiene el limite inferior del arreglo
            int limMax = arreglo.Max(); //variable que contiene el limite superior del arreglo
            int indiceBusqueda=0; //variable con la cual se buscara el valor deseado
            int dato = 7; //dato que se busca dentro del arreglo
            bool encontrado = false; //variable para mostrar mensaje en caso de encontrar o no el dato
            
            while(limMin<=limMax && encontrado == false) //mientras el limite minimo sea menor o igual al limite mayor, y que ademas aun no se haya encontrado el dato buscado...
            {
                indiceBusqueda = (limMin + limMax) / 2; //se suma el valor del limite minimo que delimita la busqueda mas el limite mayor y se divide entre 2 para tener una posicion en el array

                if (arreglo[indiceBusqueda]==dato) //Si la posicion donde se busco el dato es correcta, se cambia el bool a verdadero
                {
                    encontrado = true;
                }
                else if(arreglo[indiceBusqueda]>dato) //Si la posicion donde se busco el dato es mayor al dato que se busca, se reduce el limite mayor
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
                Console.WriteLine("El grupo del chico, que es el {0}, se ha localizado en la hoja {1}",dato ,indiceBusqueda);
            else
                Console.WriteLine("El grupo del chico, que es el {0}, no se ha encontrado, el profe perdio la lista", dato);
            
        }
    }
}
