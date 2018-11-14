using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_MonroyLopezArielAlejandro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se crean los nodos
            Nodo Cnodo = new Nodo("C", null);
            Nodo Anodo = new Nodo("A", Cnodo);
            Nodo Dnodo = new Nodo("D", Cnodo);
            Nodo Fnodo = new Nodo("F", Cnodo);
            Nodo Gnodo = new Nodo("G", Cnodo);
            Nodo Bnodo = new Nodo("B", Anodo);
            Nodo Enodo = new Nodo("E", Anodo);

            //Se agregan los nodos hijos a los nodos padres
            Cnodo.agregarHijo(Anodo);
            Cnodo.agregarHijo(Dnodo);
            Cnodo.agregarHijo(Fnodo);
            Cnodo.agregarHijo(Gnodo);
            Anodo.agregarHijo(Bnodo);
            Bnodo.agregarHijo(Enodo);

            //Se instancia la clase Arbol
            Arbol a = new Arbol(Cnodo);
            //Imprime el metodo que muestra la representacion del arbol, la altura y el nivel de este
            Console.WriteLine(a.aTexto());
            Console.WriteLine("Altura: " + a.aAltura());
            Console.WriteLine("Nivel: " + (a.aAltura() - 1));
            Console.ReadKey();
        }
    }
}
