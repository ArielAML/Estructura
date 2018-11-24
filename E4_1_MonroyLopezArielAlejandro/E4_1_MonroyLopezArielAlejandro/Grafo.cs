using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_1_MonroyLopezArielAlejandro
{
    public class Grafo
    {
        //Propiedades del grafo
        public int vertices { get; set; }
        List<int>[] vectores;
        public int destino;

        public Grafo(int parametro)
        {
            vertices = parametro;
            vectores = new List<int>[parametro];
            for (int i = 0; i < parametro; i++)
            {
                vectores[i] = new List<int>();
            }
        }

        public void integrarRuta(int inicio, int destino)
        {
            this.destino = destino;
            vectores[inicio].Add(destino);
        }

        public void rutaInicioAFin(int inicio)
        {
            Console.Clear();
            List<string> Destinos = new List<string>()
            {
                "San Francisco", "Los Angeles", "Denver", "Chicago", "Atlanta", "Boston", "Nueva York", "Miami"
            };
            Stack<int> pila = new Stack<int>();
            pila.Push(inicio);
            Console.WriteLine("La ruta mas corta es:");
            while (pila.Count !=0)
            {
                int temp = pila.Pop();
                Console.Write("=> {0}", Destinos[temp]);
                foreach (int item in vectores[temp])
                {
                    pila.Push(item);
                }
            }
        }
    }
}
