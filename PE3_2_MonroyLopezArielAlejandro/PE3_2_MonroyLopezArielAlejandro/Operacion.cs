using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE3_2_MonroyLopezArielAlejandro
{
    public class Operacion
    {
        //Inicializo todas las listas y variables que necesito globales para usarlas toda la clase
        Tarea ToDo;
        List<Tarea> noIniciadas = new List<Tarea>();
        List<Tarea> enProceso = new List<Tarea>();
        List<Tarea> terminadas = new List<Tarea>();
        public string nomTarea, descTarea, fechaIn, descEst, fechaLim,ubicar;
        public int estatus = 0, noTarea=0, opcion=0, modopc=0;
        public int modstatus, modlista;

        public void verTareas() //Metodo que despliega las tareas que hay en cada una de las listas
        {
            Console.Clear();
            Console.WriteLine("TAREAS NO INICIADAS:\n"); 
            if (noIniciadas.Count == 0) //Si la lista de tareas no iniciadas esta vacia, imprime el mensaje 
            {
                Console.WriteLine("NO HAY TAREAS SIN INICIAR\n");
            }
            else //Si la lista tiene elemento(s), imprime cada propiedad de los objetos dentro de esta
            {
                foreach (var item in noIniciadas)
                {
                    Console.WriteLine("Tarea #{0}: ", item.id);
                    Console.WriteLine("Nombre de tarea: {0}", item.nombreTarea);
                    Console.WriteLine("Descripcion de la tarea: \n{0}\n", item.descripcionTarea);
                    Console.WriteLine("Fecha de inicio: {0}", item.fechaInicio);
                    Console.WriteLine("Descripcion del status: \n{0}\n", item.descripcionStatus);
                    Console.WriteLine("Fecha limite: {0}\n", item.fechaFinal);
                }
            }
            Console.ReadKey();
            Console.WriteLine("TAREAS EN PROCESO: \n"); 
            if (enProceso.Count == 0) //Si la lista de tareas en proceso esta vacia, imprime el mensaje
            {
                Console.WriteLine("NO HAY TAREAS EN PROCESO\n");
            }
            else //Si la lista tiene elemento(s), imprime cada propiedad de los objetos dentro de esta
            {
                foreach (var item in enProceso)
                {
                    Console.WriteLine("Tarea #{0}: ", item.id);
                    Console.WriteLine("Nombre de tarea: {0}\n", item.nombreTarea);
                    Console.WriteLine("Descripcion de la tarea: \n{0}\n", item.descripcionTarea);
                    Console.WriteLine("Fecha de inicio: {0}\n", item.fechaInicio);
                    Console.WriteLine("Descripcion del status: \n{0}\n", item.descripcionStatus);
                    Console.WriteLine("Fecha limite: {0}\n", item.fechaFinal);
                }
            }
            Console.ReadKey();
            Console.WriteLine("TAREAS TERMINADAS:\n");
            if (terminadas.Count == 0) //Si la lista de tareas terminadas esta vacia, imprime el mensaje
            {
                Console.WriteLine("NO HAY TAREAS TERMINADAS\n");
            }
            else //Si la lista tiene elemento(s), imprime cada propiedad de los objetos dentro de esta
            {
                foreach (var item in terminadas)
                {
                    Console.WriteLine("Tarea #{0}: ", item.id);
                    Console.WriteLine("Nombre de tarea: {0}\n", item.nombreTarea);
                    Console.WriteLine("Descripcion de la tarea: \n{0}\n", item.descripcionTarea);
                    Console.WriteLine("Fecha de inicio: {0}\n", item.fechaInicio);
                    Console.WriteLine("Descripcion del status: \n{0}\n", item.descripcionStatus);
                    Console.WriteLine("Fecha limite: {0}\n", item.fechaFinal);
                }
            }
            Console.ReadKey();
            
        }

        public void agregarTarea() //Metodo para crear una nueva tarea a la lista que el usuario elija
        {
            Console.Clear();

            Tarea ToDo = new Tarea();
            //Se crea el objeto con todas sus propiedades y se almacena en la lista que corresponda al status
            noTarea = noIniciadas.Count + enProceso.Count + terminadas.Count + 1; 
            Console.WriteLine("Creando Tarea No.{0}", noTarea);
            ToDo.id = noTarea; 
            Console.Write("Nombre de la tarea: ");
            ToDo.nombreTarea = Console.ReadLine(); 
            Console.Write("Descripcion: ");
            ToDo.descripcionTarea = Console.ReadLine(); 
            Console.Write("Fecha de inicio: ");
            ToDo.fechaInicio = Console.ReadLine(); 
            do 
            { //Se le pregunta al usuario en donde quiere que se almacene la tarea recien creada
                Console.Write("Estatus:\n1.- No iniciada\n2.- En proceso \n3.- Terminado\n ...: ");
                estatus = int.Parse(Console.ReadLine());
                if (estatus == 1)
                {
                    ToDo.status = true;
                }
                else if (estatus == 2)
                {
                    ToDo.status = true;
                }
                else if (estatus == 3)
                {
                    ToDo.status = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("La opcion ingresada no es valida, intentelo de nuevo");
                    Console.ReadKey();
                }
            }
            while (estatus < 1 && estatus > 3); //Repite el ciclo hasta que el usuario elija una de las opciones disponibles
            Console.Write("Descripcion del estatus: ");
            ToDo.descripcionStatus = Console.ReadLine();
            Console.Write("Fecha limite: ");
            ToDo.fechaFinal = Console.ReadLine();
            //Dependiendo el status que el usuario le haya dado a la tarea, esta se va a su lista correspondiente
            if (estatus ==1)
            {
                noIniciadas.Add(ToDo);
            }
            else if ( estatus == 2)
            {
                enProceso.Add(ToDo);
            }
            else if (estatus == 3)
            {
                terminadas.Add(ToDo);
            }
        }

        public void modificarTarea()
        {
            //Se resetean las variables
            modopc = 0;
            modstatus = 0;
            modlista = 0;

            Console.Clear();
            //Se le pregunta al usuario en que lista se encuentra la tarea que quiere modificar
            Console.Write("La tarea que quiere modificar esta...\n1.- No iniciada?\n2.- En proceso?\n" +
                "3.- Terminada?\n ...: ");
            modopc = int.Parse(Console.ReadLine());
            switch (modopc) //Dependiendo la opcion que elija el usuario, se le preguntara cual es el numero de la tarea que busca
            {               //Si este se encuentra en la lista que seleccione, le pedira que ingrese el status actual de la tarea
                            //Y una nueva descripcion. Despues eliminara el objeto de la lista en la que estaba
                case 1:
                    Console.Clear();
                    Console.Write("Ingrese el numero de la tarea: ");
                    modstatus = int.Parse(Console.ReadLine());
                    Console.Write("La tarea esta:\n1.- En proceso?\n2.- Finalizada?\n ...:");
                    modlista = int.Parse(Console.ReadLine());
                    foreach (var item in noIniciadas)
                    {
                        if (item.id == modstatus && modlista ==1)
                        {
                            Console.WriteLine("\nIngrese nueva descripcion del estatus:");
                            item.descripcionStatus = Console.ReadLine();
                            enProceso.Add(item);
                            Console.WriteLine("\nLa tarea ha cambiado su estatus");
                            Console.ReadKey();
                        }
                        else if(item.id==modstatus && modlista == 2)
                        {
                            Console.WriteLine("Ingrese nueva descripcion del estatus:");
                            item.descripcionStatus = Console.ReadLine();
                            terminadas.Add(item);
                            Console.WriteLine("\nLa tarea ha cambiado su estatus");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("La tarea que indico es inexistente");
                            Console.ReadKey();
                        }
                    }
                    noIniciadas.RemoveAll((x) => x.id == modstatus);
                    break;
                case 2:
                    Console.Clear();
                    Console.Write("Ingrese el numero de la tarea: ");
                    modstatus = int.Parse(Console.ReadLine());
                    Console.Write("La tarea esta:\n1.- Sin iniciar?\n2.- Finalizada?\n ...:");
                    modlista = int.Parse(Console.ReadLine());
                    foreach (var item in enProceso)
                    {
                        if (item.id == modstatus && modlista == 1)
                        {
                            Console.WriteLine("\nIngrese nueva descripcion del estatus:");
                            item.descripcionStatus = Console.ReadLine();
                            noIniciadas.Add(item);
                            Console.WriteLine("\nLa tarea ha cambiado su estatus");
                            Console.ReadKey();
                        }
                        else if (item.id == modstatus && modlista == 2)
                        {
                            Console.WriteLine("Ingrese nueva descripcion del estatus:");
                            item.descripcionStatus = Console.ReadLine();
                            terminadas.Add(item);
                            Console.WriteLine("\nLa tarea ha cambiado su estatus");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\nLa tarea que indico es inexistente");
                            Console.ReadKey();
                        }
                    }
                    enProceso.RemoveAll((x) => x.id == modstatus);
                    break;
                case 3:
                    Console.Clear();
                    Console.Write("Ingrese el numero de la tarea: ");
                    modstatus = int.Parse(Console.ReadLine());
                    Console.Write("La tarea esta:\n1.- Sin iniciar?\n2.- En proceso?\n ...:");
                    modlista = int.Parse(Console.ReadLine());
                    foreach (var item in terminadas)
                    {
                        if (item.id == modstatus && modlista == 1)
                        {
                            Console.WriteLine("\nIngrese nueva descripcion del estatus:");
                            item.descripcionStatus = Console.ReadLine();
                            noIniciadas.Add(item);
                            Console.WriteLine("\nLa tarea ha cambiado su estatus");
                            Console.ReadKey();
                        }
                        else if (item.id == modstatus && modlista == 2)
                        {
                            Console.WriteLine("Ingrese nueva descripcion del estatus:");
                            item.descripcionStatus = Console.ReadLine();
                            enProceso.Add(item);
                            Console.WriteLine("\nLa tarea ha cambiado su estatus");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("La tarea que indico es inexistente");
                            Console.ReadKey();
                        }
                    }
                    terminadas.RemoveAll((x) => x.id == modstatus);
                    break;
            }
        }
        
        public void menu()
        {
            do
            {
                Console.Clear();
                //Despliega los mensajes de inicio con las opciones que pueda elijir el usuario
                Console.WriteLine("\t ####Lista de tareas####");
                Console.Write("\tQue desea realizar?\n\t1.- Ver tareas\n\t2.- Agregar tarea\n\t3.- Modificar tarea\n" +
                    "\t4.- Cerrar el programa\n\t ...: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        verTareas(); //Ejecuta el metodo para ver las listas
                        break;
                    case 2:
                        agregarTarea(); //Ejecuta el metodo para crear un nuevo objeto y almacenarlo en una lista
                        break;
                    case 3:
                        modificarTarea(); //Ejecuta el metodo para mandar una tarea de una lista a otra
                        break;
                    case 4:
                        Environment.Exit(0); //Cierra el programa
                        break;
                    default:
                        Console.WriteLine("La opcion ingresada no es valida, porfavor intente de nuevo"); //Mensaje de error
                        break;
                }
            }
            while (opcion != 4); //Mientras la opcion no sea 4, el menu se repite
        }
    }
}
