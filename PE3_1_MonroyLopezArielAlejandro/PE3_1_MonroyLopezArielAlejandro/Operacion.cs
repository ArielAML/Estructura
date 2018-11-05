using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE3_1_MonroyLopezArielAlejandro
{
    public class Operacion
    {
        //Listas y variables globales que utilizare en el transcurso de la clase
        Aro rueda;
        List<int> ordenar = new List<int>();
        Stack<Aro> torre1 = new Stack<Aro>();
        Stack<Aro> torre2 = new Stack<Aro>();
        Stack<Aro> torre3 = new Stack<Aro>();
        Stack<Aro> comparar = new Stack<Aro>();
        public int cantidad=0;
        public int opcion = 0;
        public int numero = 0;
        public int contAroMenor = 0;
        public int contador = 0;
        public bool numErr = true;

        public void menu()//Despliego los mensajes de bienvenida y la primera instruccion
        {
            Console.WriteLine("\t=====Torres de Hanoi=====");
            Console.Write("Cuantos aros desea que tenga la torre? ");
            cantidad = int.Parse(Console.ReadLine());
            acomodo();//Ejecuto el metodo para acomodar los aros
            resolver();//Ejecuto el metodo para acomodar los aros de mayor a menor en la torre 3
            Console.ReadKey();
        }

        public void acomodo()//Metodo para ordenar los valores dentro de la torre 1
        {
            for (int i = 0; i < cantidad; i++)
            {
                 ordenar.Add(i+1); 
            }
            
            ordenar = (from p in ordenar orderby p descending select p).ToList();
            foreach (var item in ordenar) //Ordena los elementos de una lista a la pila torre1
            {
                Aro rueda = new Aro();
                rueda.longitud = item;
                torre1.Push(rueda);
                comparar.Push(rueda);
            }
            //Le doy valores iniciales a las otra torres para evitar errores de que las torres esten vacias
            Aro borrar = new Aro();
            borrar.longitud = 0;
            torre2.Push(borrar);
            torre3.Push(borrar);
            Console.WriteLine("\nTorre 1: ");
            foreach (var bala in torre1)//Muestra que efectivamente la torre 1 almaceno los valores
            {
                Console.WriteLine(bala.longitud);
            }
        }

        public void resolver() //Utiliza un algoritmo para resolver parte por parte el proceso sin tener error
        {
            while(torre3.Count!=cantidad)
            {
                if (contAroMenor ==0 || contAroMenor %2==0)
                {
                    torre3.Push(torre1.Pop());
                    contAroMenor++;
                    contador++;
                    if (torre2 == null)
                    {
                        torre2.Push(torre1.Peek());
                        torre1.Pop();
                        contador++;
                    }
                    else if (torre1 == null)
                    {
                        torre1.Push(torre2.Peek());
                        torre2.Pop();
                        contador++;
                    }
                    else if (torre2.Peek().longitud > torre1.Peek().longitud)
                    {
                        if(torre2.Peek().longitud == 0)
                        {
                            torre2.Pop();
                        }
                        torre2.Push(torre1.Peek());
                        torre1.Pop();
                        contador++;
                    }
                    else if (torre1.Peek().longitud > torre2.Peek().longitud)
                    {
                        if (torre1.Peek().longitud == 0)
                        {
                            torre1.Pop();
                        }
                        torre1.Push(torre2.Peek());
                        torre2.Pop();
                        contador++;
                    }
                }
                else
                {
                    torre1.Push(torre3.Peek());
                    torre3.Pop();
                    contAroMenor++;
                    contador++;
                    if (torre3.Peek().longitud > torre2.Peek().longitud)
                    {
                        torre3.Push(torre2.Peek());
                        torre2.Pop();
                        contador++;
                    }
                    else if (torre3==null)
                    {
                        torre3.Push(torre2.Peek());
                        torre2.Pop();
                        contador++;
                    }
                    else if (torre2.Peek().longitud > torre3.Peek().longitud)
                    {
                        if (torre2.Peek().longitud == 0)
                        {
                            torre2.Pop();
                        }
                        torre2.Push(torre3.Peek());
                        torre3.Pop();
                        contador++;
                    }
                    else if (torre2==null)
                    {
                        torre2.Push(torre3.Peek());
                        torre3.Pop();
                        contador++;
                    }
                }
            }
            //Cuando termine el proceso, mostrara todos los elementos dentro de la torre 3 y tambien la cantidad de movimientos que se tomaron
            Console.WriteLine("Proceso terminado: \nTorre3:\n");
            foreach (var item in torre3)
            {
                Console.WriteLine(item.longitud);
            }
            Console.WriteLine("Numero de movidas realizadas: {0}", contador);
        }
    }
}
