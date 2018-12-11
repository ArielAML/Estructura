using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_U6_MonroyLopezArielAlejandro
{
    public class Program
    {
        //El metodo de busqueda por funcion hash le da a cada elemento dentro del array un dato clave,
        //este dato se transforma en el indice para encontrar la posicion dentro del arreglo.
        //Este metodo no necesita tener los elementos del array ordenados de ninguna manera, ya que sin 
        static void Main(string[] args)
        {
            Ejemplo1 E = new Ejemplo1(); //Instanciar la clase Ejemplo1
            E.main(); //Llamar al metodo dentro de la clase Ejemplo1
            Console.ReadKey();
        }
    }
}
