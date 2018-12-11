using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_U6_MonroyLopezArielAlejandro
{
    public class Ejemplo1
    {
        public void main()
        {
            int[] arreglo = new int[100]; //Vector donde se simularan los numeros de control de los alumnos
            int NControl; //variable para guardar el numero de control autogenerado
            int cont = 0; //contador para conocer el indice del dato que se busca en el array
            int datollave; //dato que el usuario proporsiona para buscar en el array
            int dato; //variable que cambia su valor para poder buscar coincidencias
            string Nserie; //variable temporal
            bool encontrado = false; //variable para determinar si el dato buscado se encuentra en el array o no

            Console.Clear(); //Limpia la consola

            //Contexto del ejemplo
            Console.WriteLine("\n\t\t Ejemplo de busqueda por funcion Hash\n\n" +
                "En una institucion estudiantil de dudosa procedencia, ingresan\n" +
                "solo 100 alumnos, los cuales son registrados con un numero de\n" +
                "produc... de control, que se almacena en un arreglo.\n" +
                "El numero de control esta conformado por la generacion del alumno\n" +
                "y su orden de ingreso.\n");

            //For para generar 100 numeros dentro del array
            for (int i = 0; i < 100; i++)
            {
                if (i < 10) //Si el iterador es menor a 10, el string llevara un "0" al final
                {
                    Nserie = "1721210" + i.ToString(); //valor string para añadir los numeros de control al arreglo
                    NControl = int.Parse(Nserie); //convierte el string en un int y lo almacena en una variable para poder llevarla al arreglo
                }
                else //Si el iterador es mayor a 10, el string no tendra un 0 al final
                {
                    Nserie = "172121" + i.ToString(); //valor string para añadir los numeros de control al arreglo
                    NControl = int.Parse(Nserie); //convierte el string en un int y lo almacena en una variable para poder llevarla al arreglo
                }
                arreglo[i] = NControl; //añade el numero de control ya armado dentro del arreglo
            }
            
            //Despliega cara numero de control y muestra su posicion dentro del array (esto para confirmar que la busqueda si funciona)
            foreach (int item in arreglo) 
            {
                cont++;
                Console.WriteLine("{0}.- {1}", cont, item);
            }

            cont = 0; //La variable regresa a 0 para poder usarla con otro proposito mas adelante

            try //Ejecuta una excepcion en caso de que ocurra un error
            {
                //Se recibe el valor que el usuario busca en el arreglo
                Console.WriteLine("Ingrese el numero de control que busca (de la serie 172121##): ");
                datollave = int.Parse(Console.ReadLine());

                //Este proceso se ejecuta siempre y cuando el contador sea menor a 100 y que la variable booleana sea falsa
                //esto es para que el contador vaya en aumento para poder encontrar la coincidencia y determinar la posicion en el arreglo
                do
                {
                    cont++;
                    if (datollave < 10) //Si el dato llave que ingreso el usuario es menor a 10, el string utilizado tendra un "0" al final
                    {
                        dato = int.Parse("1721210" + datollave.ToString());

                        if (dato == arreglo[cont]) //Si hay coincidencia, al contador se le aumenta 1 y el booleano se hace true
                        {
                            cont++;
                            encontrado = true;
                        }
                    }
                    else if (datollave >= 10) //Si el dato llave que ingreso el usuario es mayor a 10, el string no llevara un "0" al final
                    {
                        dato = int.Parse("172121" + datollave.ToString());
                        if (dato == arreglo[cont]) //Si hay coincidencia, al contador se le aumenta 1 y el booleano se hace true
                        {
                            cont++;
                            encontrado = true;
                        }
                    }
                } while (cont < 100 && encontrado == false);

                //Cuando acabe el ciclo, se determinara dependiendo la variable booleana si se encontro el dato o no
                if (encontrado == true)
                {
                    Console.WriteLine("El numero de control {0}, esta en la posicion {1} del arreglo", arreglo[datollave], (cont));
                }
                else
                {
                    //Si el dato que se busco no se encuentra en el arreglo, manda un mensaje de que no se encontro y ademas reiniciar el metodo para buscar otro dato
                    Console.WriteLine("El numero de control que busca no existe o esta incorrecto");
                    Console.ReadKey();
                    main();
                }
            }
            catch(Exception e)
            {
                //Manda mensaje de error y ademas reinicia el metodo con recursividad
                Console.Write("El dato que ingreso no es valido\n"+e.Message);
                Console.ReadKey();
                main();
            }
            
        }
    }
}
