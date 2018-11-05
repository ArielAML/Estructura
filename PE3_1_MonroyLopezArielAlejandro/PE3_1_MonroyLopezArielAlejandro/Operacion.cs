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

        public void menu()
        {
            Console.WriteLine("\t=====Torres de Hanoi=====");
            Console.Write("Cuantos aros desea que tenga la torre? ");
            cantidad = int.Parse(Console.ReadLine());
            acomodo();
            //Console.Write("Elija la opcion que quiera: \n#1 - Mostrar paso a paso\n#2 - Mostrar termino\n ...: ");
            //opcion = int.Parse(Console.ReadLine());
            resolver();
            Console.ReadKey();
        }

        public void acomodo()
        {
            for (int i = 0; i < cantidad; i++)
            {
                //Console.Write("Ingrese el numero del aro #{0}: ", i+1);
                //numero = int.Parse(Console.ReadLine());
                //if (ordenar.Count == 0)
                //{
                    ordenar.Add(i+1);
                //}
                //else
                //{
                //    foreach (var item in ordenar)
                //    {
                //        while (item == numero)
                //        {
                //            Console.WriteLine("Ya hay un aro de este tamanio, ingrese un tamanio diferente: ");
                //            numero = int.Parse(Console.ReadLine());
                //        }
                //    }
                //    ordenar.Add(numero);
                //}
            }
            
            ordenar = (from p in ordenar orderby p descending select p).ToList();
            foreach (var item in ordenar)
            {
                Aro rueda = new Aro();
                rueda.longitud = item;
                torre1.Push(rueda);
                comparar.Push(rueda);
            }
            Aro borrar = new Aro();
            borrar.longitud = 0;
            torre2.Push(borrar);
            torre3.Push(borrar);
            Console.WriteLine("\nTorre 1: ");
            foreach (var bala in torre1)
            {
                Console.WriteLine(bala.longitud);
            }
        }

        public void resolver()
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
            Console.WriteLine("Proceso terminado: \nTorre3:\n");
            foreach (var item in torre3)
            {
                Console.WriteLine(item.longitud);
            }
            Console.WriteLine("Numero de movidas realizadas: {0}", contador);
        }
    }
}
