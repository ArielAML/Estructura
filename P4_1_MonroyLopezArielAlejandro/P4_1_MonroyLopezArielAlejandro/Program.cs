using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_MonroyLopezArielAlejandro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se crean los nodos
            Nodo Enodo = new Nodo("E", null);
            Nodo Anodo = new Nodo("A", Enodo);
            Nodo Bnodo = new Nodo("B", Anodo);
            Nodo Cnodo = new Nodo("C", Anodo);
            Nodo Dnodo = new Nodo("D", Anodo);
            Nodo Fnodo = new Nodo("F", Enodo);
            //Se agregan los nodos hijos a los nodos padres
            Enodo.agregarHijo(Anodo);
            Enodo.agregarHijo(Fnodo);
            Anodo.agregarHijo(Bnodo);
            Anodo.agregarHijo(Cnodo);
            Anodo.agregarHijo(Dnodo);
            //Se instancia la clase Arbol
            Arbol a = new Arbol(Enodo);
            //Imprime el metodo que muestra la representacion del arbol, la altura y el nivel de este
            Console.WriteLine(a.aTexto());
            Console.WriteLine("Altura: " + a.aAltura());
            Console.WriteLine("Nivel: " + (a.aAltura() - 1));
            Console.ReadKey();
        }
    }
}
