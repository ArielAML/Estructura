using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_4_MonroyLopezArielAlejandro
{
    public class Grafo
    {
        //propied del grafo
        public string[,] matriz = new string[7, 7];


        public void GeneraMatriz() //Metodo que llena con espacios vacios la matriz
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    matriz[i, j] = "";
                }
            }
        }

        public void LlenarMatriz(Nodo uno, Nodo dos) //Metodo que altera la matriz poniendo en el espacio correspondiente la relacion de 2 nodos
        {
            foreach (string item in matriz)
            {
                if (item != (uno.valor + " --- " + dos.valor))
                {
                    matriz[uno.espacioMatriz, dos.espacioMatriz] = " "+uno.valor + " --- " + dos.valor +" |";
                }
                else
                {
                    matriz[0, 0] = "A --- A";
                }
            }
        }
        
        public void mostrar_camino() //Muestra cada relacion dentro de la matriz, en los espacios vacios no se imprimen y los salta
        {
            foreach (string item in matriz)
            {
                if (item == "")
                {

                }
                else
                {
                    Console.WriteLine(item);
                }
            }
        } 
    } 
}
