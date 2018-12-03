using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_U6_MonroyLopezArielAlejandro
{
    public class Ejemplo1
    {
        public void MostrarEj1()
        {
            Console.WriteLine("\n\t\tDentro de un centro comercial, poco despues de recien abrir, \n\t\thubo un cliente que compro 11 productos, sin embargo" +
            "se fue con 13, \n\t\tse desea saber el numero de cliente para poder identificar el numero \n\t\tde ticket y detenerlo" +
            "en el estacionamiento...\n"); //Situacion de ejemplo

            int[] array = new int[] { 20, 5, 12, 4, 8, 11, 13 }; //Cada espacio contiene el numero de productor que cada cliente compro
            int nProductos = 11; //Dato que se esta buscando dentro del array
            bool identificado = false; //Condicion para el metodo de busqueda
            int nCliente = 0; //iterador

            while (identificado == false && nCliente < array.Length) //Esta parte del codigo se repetira mientras que la condicion sea falsa            
            {                                                      //y que el numero de clientes sean los que estan dentro del array
                Console.Write("\t\tEl cliente compro {0} productos: ", array[nCliente]);
                if (array[nCliente] == nProductos) //Si el dato del array coincide con el dato que se busca...
                {
                    Console.WriteLine("Es el ladron");//Se imprime este mensaje
                    identificado = true; //La condicion cambia a verdadera para salir del ciclo
                }
                else //Si el dato es diferente al que se busca...
                {
                    nCliente++; //Se aumenta 1 al iterador para buscar el dato querido en la siguiente posicion del arreglo
                    Console.WriteLine("Innocente");
                }
            }

            if (identificado == true) //Si la condicion es verdadera arroja un mensaje con la posicion donde se ubica el dato buscado
                Console.WriteLine("\t\tEl ladron fue el cliente no.{0}", nCliente);
            else //Imprime que no se hallo el dato en el array
                Console.WriteLine("\t\tEl ladron se hecho a la fuga");
        }
    }
}
