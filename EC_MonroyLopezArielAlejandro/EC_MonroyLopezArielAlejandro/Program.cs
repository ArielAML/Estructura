using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace EC_MonroyLopezArielAlejandro
{
    class Program
    {
        static void Main(string[] args)
        {
            int kk = 2, pp=1, cc=3;
            Stack Pila = new Stack();

            Pila.Push(kk);
            Pila.Push(pp);
            Pila.Push(cc);
            if (Pila.Contains(kk)==true) //Si la pila contiene la variable, arroja true
            {
                Console.Write("Existe el valor {0} en la pila", kk);
            }
            Stack arrai = new Stack(Pila.ToArray()); //Hace una copia de la pila y la manda a un array
            Pila.Pop();

            Console.WriteLine("\n{0} ", Pila.Count);
            foreach (var item in Pila) //Comparo la pila con la copia de la lista
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine("\n{0} ",arrai.Count);
            foreach (var item in arrai)
            {
                Console.Write("{0} ", item);
            }
            
            Pila.GetType();
            Pila.GetEnumerator();
            Console.ReadKey();
        }
    }
}
