using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_MonroyLopezArielAlejandro
{
    class Program
    {
        public static void P1()
        {
            int numeroSucecion = 0;
            Console.WriteLine("Programa que muestra el valor menor y mayor de una sucesion que \ningrese el usuario.\n");
            Console.Write("Ingrese cuantos numeros quieres ingresar: ");
            numeroSucecion = int.Parse(Console.ReadLine());
            int[] vector = new int[numeroSucecion];
            for (int cont = 0; cont < numeroSucecion; cont++)
            {

                Console.Write("\nIngrese el valor {0}: ", cont + 1);
                vector[cont] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nEl valor menor en la sucecion es: {0}", vector.Min());
            Console.WriteLine("El valor mayor en la sucecion es: {0}", vector.Max());
            Console.ReadKey();
        }



        public static void P2()
        {
            int palabras = 0;
            Console.WriteLine("Programa que invierte el orden de los valores que introdusca \nel usuario.\n");
            Console.Write("Ingrese cuantas palabras quiere: ");
            palabras = int.Parse(Console.ReadLine());
            string[] vector = new string[palabras];
            for (int contador = 0; contador < palabras; contador++)
            {
                Console.Write("\nIngrese el dato {0}: ", contador + 1);
                vector[contador] = Console.ReadLine();
            }
            vector = vector.Reverse().ToArray();
            Console.WriteLine("\nEl orden inverso de las palabras ingresadas es...\n");
            for (int conta = 0; conta < palabras; conta++)
            {
                if (conta == 0)
                {
                    Console.Write(vector[conta]);
                }
                else
                {
                    Console.Write(" " + vector[conta]);
                }           
            }
            Console.ReadKey();
        }



        public static void P3()
        {
            int Respuesta = 0;
            double posicionM = 0;
            Console.WriteLine("Programa que indica cual fue el ultimo numero mayor valor introducido \ny cual es su posicion en la sucesion.\n");
            Console.Write("Ingrese cuantos valores desea introducir: ");
            int numeroIngrsos = int.Parse(Console.ReadLine());
            double[] vector = new double[numeroIngrsos];

            for (int contador = 0; contador < numeroIngrsos; contador++)
            {
                Console.Write("Ingrese el dato {0} de la sucesion: ", contador + 1);
                vector[contador] = Convert.ToDouble(Console.ReadLine());
                if (vector[contador] >= posicionM)
                {
                    posicionM = vector[contador];
                    Respuesta = contador + 1;
                }
            }
            Console.WriteLine("\nEl valor mayor ingresado fue: {0}", vector.Max());
            Console.WriteLine("En la posicion: {0} ", Respuesta);
            Console.ReadKey();
        }



        public static void P4()
        {
            double posicionMenor = 0;
            double[] vector = new double[3];
            Console.WriteLine("Programa que indica el menor numero de 3 que ingrese el usuario.\n");
            for (int contador = 0; contador < 3; contador++)
            {
                Console.Write("Ingrese el numero del elemento {0}: ", contador + 1);
                vector[contador] = Convert.ToDouble(Console.ReadLine());
                if (contador > 0)
                {
                    if (vector[contador] < vector[contador - 1])
                    {
                        posicionMenor = contador + 1;
                    }
                }
                else
                {
                    posicionMenor = contador + 1;
                }
            }
            Console.Write("\nEl elemento con el valor minimo capturado en la posicion {0} y su valor es {1}", posicionMenor, vector.Min());
            Console.ReadKey();
        }



        public static void P5()
        {
            int Respuesta = 0;
            double posicionM = 0;
            Console.WriteLine("Programa que indica la posicion del primer numero de mayor valor que \ningrese el usuario.\n");
            Console.Write("Ingrese cuantos valores desea introducir: ");
            int numeroIngrsos = int.Parse(Console.ReadLine());
            double[] vector = new double[numeroIngrsos];

            for (int contador = 0; contador < numeroIngrsos; contador++)
            {
                Console.Write("Ingrese el dato {0} de la sucesion: ", contador + 1);
                vector[contador] = Convert.ToDouble(Console.ReadLine());
                if (vector[contador] > posicionM)
                {
                    posicionM = vector[contador];
                    Respuesta = contador + 1;
                }
            }
            Console.WriteLine("\nEl valor mayor ingresado fue: {0}", vector.Max());
            Console.WriteLine("En la posicion: {0} ", Respuesta);
            Console.ReadKey();
        }



        public static void P6()
        {
            int numeroPalabras = 0, numeroLetras = 0;
            string palabra = "";
            Console.WriteLine("Programa que indica la palabra con mayor cantidad de letras que \ningrese el usuario.\n");
            Console.Write("Ingrese el numero de palabras que quiere escribir: ");
            numeroPalabras = int.Parse(Console.ReadLine());
            string[] vector = new string[numeroPalabras];

            for (int contador = 0; contador < numeroPalabras; contador++)
            {
                Console.Write("Ingrese la palabra {0}: ", contador + 1);
                vector[contador] = Console.ReadLine();
            }
            for (int contad = 0; contad < numeroPalabras; contad++)
            {
                if (contad > 0)
                {
                    if (vector[contad].Length > vector[contad - 1].Length)
                    {
                        numeroLetras = contad + 1;
                        palabra = vector[contad];
                        contad = numeroPalabras;
                    }
                }

                else if (contad == 0)
                {
                    numeroLetras = contad + 1;
                    palabra = vector[contad];
                }
            }
            Console.WriteLine("La palabra con mayor cantidad de letras esta en la posicion {0} y es '{1}' ", numeroLetras, palabra);
            Console.ReadKey();
        }



        public static void P7()
        {
            int numeroIngresar = 0;
            Console.WriteLine("Programa que ordena numeros al azar del 1 al 100 que el usuario ingrese.\n");
            Console.Write("Cuantos numeros desea ingresar? ");
            numeroIngresar = int.Parse(Console.ReadLine());
            int[] vector = new int[numeroIngresar];
            for (int contador = 0; contador < numeroIngresar; contador++)
            {
                Console.Write("{0}/{1} - Ingrese un numero al azar del 1 al 100: ", contador + 1, numeroIngresar);
                vector[contador] = int.Parse(Console.ReadLine());
                if (vector[contador] > 100 || vector[contador] < 1)
                {
                    do
                    {
                        Console.Write("\nEl valor introducido no esta en el rango 1 a 100\nintente de nuevo ({0}/{1}): ", contador + 1, numeroIngresar);
                        vector[contador] = int.Parse(Console.ReadLine());
                    }
                    while (vector[contador] > 100 || vector[contador] < 1);
                }
            }
            Console.Write("Numeros ingresados: \n");
            for (int cont = 0; cont < numeroIngresar; cont++)
            {
                Console.Write(" " + vector[cont]);
            }
            Console.Write("Numeros ordenados: \n");
            Array.Sort(vector);
            for (int con = 0; con < numeroIngresar; con++)
            {
                Console.Write(" " + vector[con]);
            }
            Console.ReadKey();
        }



        public static void P8()
        {
            int palindromo = 0, numero = 0, numeroInver = 0;
            Console.WriteLine("Programa que determina si el valor ingresado por el usuario es un palindromo.\n");
            Console.Write("Ingrese el supuesto palindromo de 5 digitos: ");
            numero = int.Parse(Console.ReadLine());
            while (numero / 10000 < 1 || numero / 10000 > 9)
            {
                Console.Write("El numero introducido no es de 5 digitos, intente ingresar uno diferente: ");
                numero = int.Parse(Console.ReadLine());
            }
            numeroInver = numero;
            while (numero > 0)
            {
                palindromo = palindromo * 10 + (numero % 10);
                numero = numero / 10;
            }
            if (numeroInver == palindromo)
            {
                Console.WriteLine("El numero es un palindromo");
            }
            else
            {
                Console.WriteLine("El numero no es un palindromo");
            }
            Console.Write("Numero invertido: " + palindromo);
            Console.ReadKey();
        }






        static void Main(string[] args)
        {
            string reinicio;
            do
            {
                Console.Clear();
                int Opcion = 0;
                Console.WriteLine("Practicas Evaluativas");
                Console.Write("Ingrese el numero de la practica que quiera ver... \n\nPractica 1 \nPractica 2 " +
                    "\nPractica 3 \nPractica 4 \nPractica 5\nPractica 6\nPractica 7 \nPractica 8\n     ... ");
                Opcion = int.Parse(Console.ReadLine());
                switch (Opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Practica 1...\n");
                        P1();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Practica 2...\n");
                        P2();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Practica 3...\n");
                        P3();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Practica 4...\n");
                        P4();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Practica 5...\n");
                        P5();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Practica 6...\n");
                        P6();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Practica 7...\n");
                        P7();
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Practica 8...\n");
                        P8();
                        break;
                    default:
                        break;
                }
                Console.Clear();
                Console.Write("Quiere probar ver otra practica? \n(Presione '1' para aceptar / presione otra tecla para concluir el programa): ");
                reinicio =Console.ReadLine();
            }
            while (reinicio == "1");
        }
    }
}
