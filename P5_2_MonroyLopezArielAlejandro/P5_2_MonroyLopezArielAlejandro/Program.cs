using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5_2_MonroyLopezArielAlejandro
{
    class Program
    {
        static void Main(string[] args)
        {
            double [] uno = { 11, 2, 3, 14, 18, 45, -3, -1, 6, 9 }; //vector con datos predeterminados
            QuickSort uno1 = new QuickSort(uno, 9); //Constructor donde se envian los parametros para la clase QuickSort
            uno1.quickso(uno, 0, 9); //Se mandan los parametros necesarios para que el metodo pueda ser recursivo
            uno1.mostrar(); //Metodo que muestra los datos del vector resultante

            double[] dos = { 1, 3, 5, 7, 8, 3, 9, .7071, 16.5664, 12, 0, 10 };
            QuickSort dos2 = new QuickSort(dos, dos.Count());
            dos2.quickso(dos, 0, 11);
            dos2.mostrar();

            double[] tres = { 3, 7, 15, 1.3333333333, 155, 100, 15, Math.Sqrt(3), 5, 2, 3, 2 };
            QuickSort tres3 = new QuickSort(tres, tres.Count());
            tres3.quickso(tres, 0, 11);
            tres3.mostrar();

            double[] cuatro = { 8, 19, 7, 3, 15, 23, 34, 27, 89, 101 };
            QuickSort cuatro4 = new QuickSort(cuatro, cuatro.Count());
            cuatro4.quickso(cuatro, 0, 9);
            cuatro4.mostrar();
        }
    }
}
