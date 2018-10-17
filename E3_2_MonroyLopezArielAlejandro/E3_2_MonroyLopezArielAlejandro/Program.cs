using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace E3_2_MonroyLopezArielAlejandro
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue Q = new Queue();
            Stack S = new Stack();

            for (int i = 0; i < 4; i++) //Se ingresan datos a la pila y a la cola
            {
                Q.Enqueue("Valor "+i);
                S.Push("Valor "+i);
            }

            //Se muestra la cantidad de datos que tiene la pila y la cola
            Console.WriteLine("Datos dentro de la cola: "+Q.Count);
            Console.WriteLine("Datos dentro de la pila: "+S.Count);

            Console.WriteLine("Valor que muestra la cola: "+Q.Peek());//La cola muestra el primer dato ingresado
            Console.WriteLine("Valor que muestra la pila: "+S.Peek());//LA pila muestra el ultimo dato ingresado

            Q.Dequeue(); //Elimina el dato en la primera posicion de la cola
            S.Pop(); //Eimina al dato en la ultima posicion de la pila

            //Cuenta nuevamente la cantidad de datos en la pila y la cola
            Console.WriteLine("Datos dentro de la cola despues de eliminar un dato: " + Q.Count);
            Console.WriteLine("Datos dentro de la pila despues de eliminar un dato: " + S.Count);

            //Comprueba que se elimina el primer dato en la cola y el ultimo dato en la pila
            Console.WriteLine("Valor que muestra la cola: " + Q.Peek());
            Console.WriteLine("Valor que muestra la pila: " + S.Peek());

            //Se limpia la cola y la pila
            Q.Clear();
            S.Clear();

            //Se muestra que la cola y la pila estan vacias
            Console.WriteLine("Datos dentro de la cola despues de limpiarla: " + Q.Count);
            Console.WriteLine("Datos dentro de la pila despues de limpiarla: " + Q.Count);
            Console.ReadLine();
        }
    }
}
