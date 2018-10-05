using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE2_MonroyLopezArielAlejandro
{
    class Metodos
    {
        public int RespMenu = 0;
        public static int CantNumeros = 0;
        public int Numeros=0;
        public int[] ValoresIngresados;
        public int tempMinimo = 666;
        public int tempMaximo = 0;

        public void Menu()
        {
            Console.WriteLine("###Programas que sacan el valor minimo, maximo de una sucesion finita o la sucecion invertida.###");
            Console.Write("\nIngrese la cantidad de numeros que quiere ingresar en la sucesion: ");
            CantNumeros = int.Parse(Console.ReadLine());
            int[] ValoresIngresados = new int[CantNumeros];
            for (int contador = 0; contador < CantNumeros; contador++)
            {
                Console.Write("Ingrese el valor {0} de la sucesion: ",contador +1);
                Numeros = int.Parse(Console.ReadLine());
                ValoresIngresados[contador] = Numeros;
            }
            do
            {
                
                Console.Write("Ingrese el numero que corresponda con la opcion que desee...\nValor minimo en la sucesion - 1\n" +
                                "Valor maximo en la sucesion - 2\nSucesion en rden invertido - 3\nSalir - 4\n\n   ... ");
                RespMenu = int.Parse(Console.ReadLine());
                switch (RespMenu)
                {
                    case 1:
                        Numeros = CantNumeros;
                        int Minimo = 0;
                        Console.WriteLine("\nEl valor minimo en la sucesion es: {0}", ValorMinimo(ValoresIngresados,Minimo));        
                        break;
                    case 2:
                        Numeros = CantNumeros;
                        int Maximo = 0;
                        Console.WriteLine("\nEl valor maximo en la sucesion es: {0}", ValorMaximo(ValoresIngresados,Maximo));
                        break;
                    case 3:
                        Console.Write("La sucesion inversa es: ");
                        Console.WriteLine(SucesionInversa(ValoresIngresados, Numeros));
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Write("Valor ingresado no valido, favor de intentarlo de nuevo");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (RespMenu != 1 || RespMenu != 2 || RespMenu != 3);
        }
        

        public int ValorMinimo(int[] ValIng, int minimo)
        {          
            try
            {
                if (ValIng[minimo] <= tempMinimo)
                {
                    tempMinimo = ValIng[minimo];
                    return ValorMinimo(ValIng, minimo + 1);
                }
                else
                {
                    return ValIng[minimo + 1];
                }
            }
            catch (IndexOutOfRangeException)
            {
                return tempMinimo;
            }
        }


        public int ValorMaximo(int[]ValIng,int maximo)
        {
            try
            {
                if (ValIng[maximo] >= tempMaximo)
                {
                    tempMaximo = ValIng[maximo];
                    return ValorMaximo(ValIng,maximo + 1);
                }
                else
                {
                    return ValorMaximo(ValIng,maximo+1);
                }
            }
            catch (IndexOutOfRangeException)
            {
                return tempMaximo;
            }
        }


        public int SucesionInversa(int[] valIng, int numeros)
        {
            if (numeros == 1)
            {
                return valIng[numeros-1];
            }
            else
            {
                Console.Write("{0} ", valIng[numeros - 1]);
                return SucesionInversa(valIng, numeros -1);
            }           
        }
    }
}
