using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace E3_1_MonroyLopezArielAlejandro
{
    class PedirDatos
    {
        public int numMaterias = 0, alumnMateria = 0, alumnoEnMateria = 0, direccionCalificacion = 0;
        public string nomMateria;
        public double[,] calificacion;
        public int[] numAlumnos;


        public void Pedir_Imprimir()
        {
            Console.Write("Ingrese cuantas materias hay en el periodo: "); //Se consigue el dato de cuantas materias ingresara el usuario
            numMaterias = int.Parse(Console.ReadLine());
            numAlumnos = new int[numMaterias];

            ArrayList ListMaterias = new ArrayList();

            for (int i = 0; i < numMaterias; i++) //Pregunta el nombre de cada materia dependiendo de la cantidad que ingreso el usuario
            {
                Console.Write("Ingrese el nombre de la materia #{0}: ", i + 1);
                nomMateria = Console.ReadLine();
                ListMaterias.Add(nomMateria); //Mete cada materia en una lista
            }



            calificacion = new double[numMaterias, 50];

            foreach (var item in ListMaterias) //Por cada dato dentro de la lista, pedira los datos de cuantos alumnos tiene la materia y preguntara la calificacion de cada uno
            {
                Console.Write("Cuantos alumnos tiene la clase de {0}: ", item);
                numAlumnos[alumnMateria] = int.Parse(Console.ReadLine());
                for (int k = 0; k < numAlumnos[alumnMateria]; k++)
                {
                    Console.Write("Ingrese la calificacion del alumno {0}: ", k + 1);
                    calificacion[alumnMateria, k] = double.Parse(Console.ReadLine());
                }
                alumnMateria++; //Aumenta el valor de la variable para ingresar los datos del ciclo en un espacio diferente del vector
            }

            foreach (var materia in ListMaterias) //Imprime cada clase con la cantidad de alumnos y que calificaciones tiene cada uno
            {
                Console.WriteLine("\n{0}: \n", materia);
                direccionCalificacion = 0;
                while (direccionCalificacion != numAlumnos[alumnoEnMateria])
                {
                    Console.WriteLine("Alumno #{0}: {1}", alumnoEnMateria + 1, calificacion[alumnoEnMateria, direccionCalificacion]);
                    direccionCalificacion++;
                }
                alumnoEnMateria++;
            }
            Console.ReadKey();
        }
    }
}
