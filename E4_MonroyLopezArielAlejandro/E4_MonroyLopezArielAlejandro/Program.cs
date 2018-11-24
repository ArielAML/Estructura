using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_MonroyLopezArielAlejandro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se crean los nodos del arbol a
            Nodo Anodo = new Nodo("A", null);
            Nodo Bnodo = new Nodo("B", Anodo);
            Nodo Cnodo = new Nodo("C", Anodo);
            Nodo Dnodo = new Nodo("D", Anodo);
            Nodo Enodo = new Nodo("E", Bnodo);
            Nodo Fnodo = new Nodo("F", Bnodo);
            Nodo Gnodo = new Nodo("G", Bnodo);
            Nodo Hnodo = new Nodo("H", Dnodo);
            Nodo Inodo = new Nodo("I", Dnodo);
            Nodo Jnodo = new Nodo("J", Dnodo);
            Nodo Knodo = new Nodo("K", Enodo);
            Nodo Lnodo = new Nodo("L", Enodo);
            Nodo Mnodo = new Nodo("M", Enodo);
            Nodo Nnodo = new Nodo("N", Gnodo);
            Nodo Onodo = new Nodo("O", Hnodo);
            Nodo Pnodo = new Nodo("P", Jnodo);
            Nodo Qnodo = new Nodo("Q", Jnodo);
            Nodo Rnodo = new Nodo("R", Nnodo);
            Nodo Snodo = new Nodo("S", Nnodo);
            //Se agregan los nodos hijos a los nodos padres en el arbol a
            Anodo.agregarHijo(Bnodo);
            Anodo.agregarHijo(Cnodo);
            Anodo.agregarHijo(Dnodo);
            Bnodo.agregarHijo(Enodo);
            Bnodo.agregarHijo(Fnodo);
            Bnodo.agregarHijo(Gnodo);
            Dnodo.agregarHijo(Hnodo);
            Dnodo.agregarHijo(Inodo);
            Dnodo.agregarHijo(Jnodo);
            Enodo.agregarHijo(Knodo);
            Enodo.agregarHijo(Lnodo);
            Enodo.agregarHijo(Mnodo);
            Gnodo.agregarHijo(Nnodo);
            Nnodo.agregarHijo(Rnodo);
            Nnodo.agregarHijo(Snodo);
            Hnodo.agregarHijo(Onodo);
            Jnodo.agregarHijo(Pnodo);
            Jnodo.agregarHijo(Qnodo);
            //Se instancia la clase Arbol a
            Arbol a = new Arbol(Anodo);
            //Imprime el metodo que muestra la representacion del arbol en preorden, inorden y postorden
            Console.WriteLine("PreOrden: "+a.aPreOrden());
            Console.ReadKey();

            Console.Clear();

            //Se crean los nodos del arbol b
            Nodo bAnodo = new Nodo("A", null);
            Nodo bBnodo = new Nodo("B", Anodo);
            Nodo bCnodo = new Nodo("C", Anodo);
            Nodo bDnodo = new Nodo("D", Anodo);
            Nodo bEnodo = new Nodo("E", Bnodo);
            Nodo bFnodo = new Nodo("F", Bnodo);
            Nodo bGnodo = new Nodo("G", Bnodo);
            Nodo bHnodo = new Nodo("H", Dnodo);
            //Se agregan los nodos hijos a los nodos padres en el arbol b
            bAnodo.agregarHijo(bBnodo);
            bAnodo.agregarHijo(bEnodo);
            bBnodo.agregarHijo(bCnodo);
            bBnodo.agregarHijo(bDnodo);
            bEnodo.agregarHijo(bFnodo);
            bFnodo.agregarHijo(bGnodo);
            bFnodo.agregarHijo(bHnodo);
            //Se instancia la clase Arbol b
            Arbol b = new Arbol(bAnodo);
            //Imprime el metodo que muestra la representacion del arbol en preorden, inorden y postorden
            Console.WriteLine("PreOrden: "+b.aPreOrden());
            Console.ReadKey();
        }
    }
}
