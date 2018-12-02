using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; //Se usa esta libreria para poder usar las colas (Queue)

namespace P5_U5_MonroyLopezArielAlejandro
{
    public class Radix
    {
        //Se inicializan 10 colas donde se almacenaran los numeros correspondientes para el ordenamiento
        Queue cero = new Queue();
        Queue uno = new Queue();
        Queue dos = new Queue();
        Queue tres = new Queue();
        Queue cuatro = new Queue();
        Queue cinco = new Queue();
        Queue seis = new Queue();
        Queue siete = new Queue();
        Queue ocho = new Queue();
        Queue nueve = new Queue();
        //variables auxiliares
        int nummax, temp, numtemp, aux=0;
        int mod = 10;
        int div = 1;
        int[] Sorted;

        public Radix(int []a)//constructor que solo toma y guarda el numero mas alto en el vector
        {
            nummax = a.Max();
        }

        public void RadixSort(int [] a)
        {
            //Se limpian las colas de cualquier dato que haya sido ingresado anteriormente
            cero.Clear();
            uno.Clear();
            dos.Clear();
            tres.Clear();
            cuatro.Clear();
            cinco.Clear();
            seis.Clear();
            siete.Clear();
            ocho.Clear();
            nueve.Clear();

            if (div > nummax) //si la variable divisora es mayor al numero mas alto del vector... 
            {
                foreach (int item in a) //se imprimen los datos dentro del vector y se termina el programa
                {
                    Console.Write(" " + item);
                }
            }
            else //de no ser asi...
            {
                Sorted = new int[a.Length]; //se crea un nuevo vector
                for (int i = 0; i < a.Length; i++) //este for se utiliza para ingresar los datos del vector dentro de la cola correspondiente
                {
                    temp = a[i] % mod;  //Se guarda del residuo resultante del numero del vector entre la variable
                    numtemp = temp / div; //El residuo se divide entre la variable div, para saber en que cola ira el numero
                    if (numtemp < 0) //Si el numero del vector es menor a 0, entonces se va directamente a la cola de los 0
                        cero.Enqueue(a[i]);
                    else //de no ser asi...
                    switch (numtemp) //se va a la lista correspondiendo el numero resultante
                    {
                        case 0:
                            cero.Enqueue(a[i]);
                            break;
                        case 1:
                            uno.Enqueue(a[i]);
                            break;
                        case 2:
                            dos.Enqueue(a[i]);
                            break;
                        case 3:
                            tres.Enqueue(a[i]);
                            break;
                        case 4:
                            cuatro.Enqueue(a[i]);
                            break;
                        case 5:
                            cinco.Enqueue(a[i]);
                            break;
                        case 6:
                            seis.Enqueue(a[i]);
                            break;
                        case 7:
                            siete.Enqueue(a[i]);
                            break;
                        case 8:
                            ocho.Enqueue(a[i]);
                            break;
                        case 9:
                            nueve.Enqueue(a[i]);
                            break;
                    }
                }
                //Se vacia cada cola una por una, metiendo sus valores en el vector temporal
                AVector(cero);
                AVector(uno);
                AVector(dos);
                AVector(tres);
                AVector(cuatro);
                AVector(cinco);
                AVector(seis);
                AVector(siete);
                AVector(ocho);
                AVector(nueve);
                //A las variables se les multiplica 10 para que tomen la siguiente cifra significativa
                mod = mod * 10;
                div = div * 10;
                //Se devuelve a 0 a la variable auxiliar
                aux = 0;
                RadixSort(Sorted); //Se ejecuta de nuevo el metodo con mod y div multiplicados por 10 para ordenar los valores las veces necesarias
            }
        }

        public void AVector(Queue Cola) //Metodo para ingresar los datos de una cola dentro del vector
        {
            foreach (int item in Cola)
            {
                Sorted[aux] = item;
                aux++;
            }
        }

        public void Mostrar(int[] b) //Metodo para mostrar el vector original, antes de ser ordenado
        {
            foreach (int item in b)
            {
                Console.Write(" " + item);
            }
        }
    }
}
