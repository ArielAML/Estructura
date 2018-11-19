using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_4_MonroyLopezArielAlejandro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancio la clase Grafo
            Grafo Graph = new Grafo();
            //Creo los nodos del grafo
            Nodo A = new Nodo("A", 0);
            Nodo B = new Nodo("B", 1);
            Nodo C = new Nodo("C", 2);
            Nodo D = new Nodo("D", 3);
            Nodo E = new Nodo("E", 4);
            Nodo F = new Nodo("F", 5);
            Nodo G = new Nodo("G", 6);
           
            Graph.GeneraMatriz(); //Inicializo una matriz donde sus espacios estan vacios

            //Ingreso los nodos en la matriz, que graficamente serian las aristas
            Graph.LlenarMatriz(A, A);
            Graph.LlenarMatriz(A, B);
            Graph.LlenarMatriz(B, C);
            Graph.LlenarMatriz(B, G);
            Graph.LlenarMatriz(C, D);
            Graph.LlenarMatriz(C, G);
            Graph.LlenarMatriz(D, E);
            Graph.LlenarMatriz(D, F);
            Graph.LlenarMatriz(G, F);
            Graph.LlenarMatriz(F, E);

            Graph.mostrar_camino(); //Muestra las rutas de cada nodo
            Console.ReadKey();
        }
    }
}
