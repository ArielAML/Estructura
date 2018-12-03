using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_U6_MonroyLopezArielAlejandro
{
    public class Ejemplo2
    {
        public void MostrarEj2()
        {
            Console.WriteLine("\n\t\tUn mago esta haciendo su truco de magia con una baraja de naipes, donde le da\n" +
                "\t\ta uno de sus espectadores una carta al azar, pero como sabemos\n" +
                "\t\tque la magia no existe, el mago tiene una forma de saber la carta\n" +
                "\t\tque sacaron de la baraja, encontrara la carta previa a donde se metio\n"+
                "\t\tla carta que sacaron");

            string[] cartasBaraja = new string[] {"3A", "7C", "4C", "AT", "QD"}; //Array que contiene las cartas donde puede estar la carta que busca el mago
            string dato = "4C"; //Esta es la carta que el mago esta buscando en la baraja
            bool cartaAnterior = false; //Condicion para saber si el mago encontro la carta o no
            int carta = 0; //Iterador

            while (cartaAnterior == false && carta < cartasBaraja.Length) //Esta parte del codigo se repetira mientras que la condicion sea falsa            
            {                                                      //y que las cartas sean los que estan dentro del array
                Console.Write("\t\tCarta: {0}: ", cartasBaraja[carta]);
                if (cartasBaraja[carta] == dato) //Si el dato del array coincide con el dato que se busca...
                {
                    Console.WriteLine("Esta era, entonces...");//Se imprime este mensaje
                    cartaAnterior = true; //La condicion cambia a verdadera para salir del ciclo
                    carta++; //El mago sabe que la siguiente carta es la que busca
                }
                else //Si el dato es diferente al que se busca...
                {
                    carta++; //Se aumenta 1 al iterador para buscar el dato querido en la siguiente posicion del arreglo
                    Console.WriteLine("Esta no es");
                }
            }

            if (cartaAnterior == true) //Si la condicion es verdadera arroja un mensaje con la posicion donde se ubica el dato buscado
                Console.WriteLine("\t\tLa carta que buscaba el mago era {0} y era la carta {1}", cartasBaraja[carta] ,carta);
            else //Imprime que no se hallo el dato en el array
                Console.WriteLine("\t\tOh no, algo salio mal, el mago es un fracasado");
        }
    }
}
