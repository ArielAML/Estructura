using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE3_3_MonroyLopezArielAlejandro
{
    public class Operacion
    {
        //Listas y variables globales   
        List<string> inicio = new List<string>();
        List<string> final = new List<string>();
        public int tiempo = 0;
        public void Inicio() //Metodos que despliega el mensaje del problema y describe los pasos que se tomaron para que las vacas lleguen al otro lado del puente
        {
            Console.WriteLine("Supongamos que Bob tiene cuatro vacas que quiere cruzar por un puente, pero solo un yugo,\n" +
                "que puede sostener hasta dos vacas, lado a lado, atadas al yugo. El yugo es demasiado\n" +
                "pesado para que lo lleve a traves del puente, pero puede atar (y desatar) vacas a el en muy poco tiempo.\n" +
                "De sus cuatro vacas, Mazie puede cruzar el puente en 2 minutos, Daisy puede cruzarlo en 4 minutos, Crazy\n" +
                "puede cruzarlo en 10 minutos y Lazy puede cruzar en 20 minutos. Por supuesto, cuando dos vacas estan atadas\n" +
                "al yugo, deben ir a la velocidad de la vaca mas lenta.\n" +
                "Describe como Bob puede conseguir que todas sus vacas crucen el puente en 34 minutos.");

            //Ingreso las vacas dentro de la lista, que representa el lado inicial del puente
            inicio.Add("Mazie");
            inicio.Add("Daisy");
            inicio.Add("Crazy");
            inicio.Add("Lazy");

            Console.WriteLine("\nVacas por cruzar: \n");
            foreach (var item in inicio) //Muestra a las vacas que aun no han cruzado el puente     
            {
                Console.WriteLine(item);
            }
            //Muestra la instruccion que se tomo primero
            Console.WriteLine("\nCruza Mazie y Lazy amarradas al yugo");
            tiempo += 20; //Se le suma el tiempo que se tardaron en cruzar
            //remuevo las vacas de la lista inicial y las agrega a la lista final (referencia al lado inicial del puente y el lado final)
            inicio.Remove("Mazie");
            inicio.Remove("Lazy");
            final.Add("Mazie");
            final.Add("Lazy");
            Console.WriteLine("\nVacas por cruzar: \n");
            foreach (var item in inicio) //Muestra las vacas que faltan por cruzar
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nVacas del otro lado del puente: \n"); 
            foreach (var item in final)//Muestra las vacas que ya cruzaron
            {
                Console.WriteLine(item);
            }
            //Siguiente paso es hacer que cruzen Daisy y Crazy por separado
            Console.WriteLine("\nCruza Daisy");
            tiempo += 4; //Se suma al tiempo lo que tardo Daisy en cruzar el puente
            Console.WriteLine("Cruza Crazy\n");
            tiempo += 10; //Se suma al tiempo lo que tardo Crazy en cruzar el puente
            //Remueve del inicio y agreaga a la lista final las vacas que acaban de cruzar
            inicio.Remove("Daisy");
            inicio.Remove("Crazy");
            final.Add("Daisy");
            final.Add("Crazy");
            Console.WriteLine("Vacas del otro lado del puente: ");
            foreach (var item in final)//Muestra a las vacas que ya cruzaron
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("En un tiempo de: "+ tiempo); //Muestra el tiempo total para cruzar
        }
    }
}
