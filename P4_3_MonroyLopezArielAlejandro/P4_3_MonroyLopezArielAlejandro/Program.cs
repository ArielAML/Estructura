using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_3_MonroyLopezArielAlejandro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se crean los nodos
            Nodo Knodo = new Nodo("K", null);
            Nodo Anodo = new Nodo("A", Knodo);
            Nodo Bnodo = new Nodo("B", Knodo);
            Nodo Cnodo = new Nodo("C", Knodo);
            Nodo Dnodo = new Nodo("D", Knodo);
            Nodo Enodo = new Nodo("E", Dnodo);
            Nodo Inodo = new Nodo("I", Dnodo);
            Nodo Fnodo = new Nodo("F", Enodo);
            Nodo Gnodo = new Nodo("G", Enodo);
            Nodo Jnodo = new Nodo("J", Inodo);
            Nodo Hnodo = new Nodo("H", Gnodo);
            
            //Se agregan los nodos hijos a los nodos padres
            Knodo.agregarHijo(Anodo);
            Knodo.agregarHijo(Bnodo);
            Knodo.agregarHijo(Cnodo);
            Knodo.agregarHijo(Dnodo);
            Dnodo.agregarHijo(Enodo);
            Dnodo.agregarHijo(Inodo);
            Enodo.agregarHijo(Fnodo);
            Enodo.agregarHijo(Gnodo);
            Inodo.agregarHijo(Jnodo);
            Gnodo.agregarHijo(Hnodo);


            //Se instancia la clase Arbol
            Arbol a = new Arbol(Knodo);
            //Imprime el metodo que muestra la representacion del arbol, la altura y el nivel de este
            Console.WriteLine(a.aTexto());
            Console.WriteLine("Altura: " + a.aAltura());
            Console.WriteLine("Nivel: " + (a.aAltura() - 1));
            Console.ReadKey();
        }
    }
}
