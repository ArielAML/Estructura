using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace E3_3_MonroyLopezArielAlejandro
{
    public class Operacion
    {
        //Variables, vectores y pila necesarios para ejecutar el programa
        public string tipoCarta, numCarta, reinicio, simboloCarta;
        public int numcartasMano = 0, ganadas = 0, perdidas = 0, valorAs = 1, sumador = 0, opcionMenu=0;
        public bool opcion=true;
        public Carta card;
        public Random rndm;
        public Stack<Carta> baraja;

        public void CrearBaraja() //Metodo para crear y revolver la baraja con la que se jugara
        {
            List<Carta> L = new List<Carta>(); 
            rndm = new Random();
            baraja = new Stack<Carta>();
            for (int i = 1; i < 5; i++) //Ciclos para darle los atributos a los objetos carta
            {
                switch (i)
                {
                    case 1:
                        tipoCarta = "♥C";
                        break;
                    case 2:
                        tipoCarta = "♦D";
                        break;
                    case 3:
                        tipoCarta = "♠E";
                        break;
                    case 4:
                        tipoCarta = "♣T";
                        break;
                }
                for (int j = 1; j < 14; j++) //Crea 13 cartas con un mismo simbolo, al terminar, el contador inicial cambia el simbolo y se crean otras 13 cartas
                {
                    card = new Carta();
                    if (j == 1) // Si el valor del contador es 1, la carta sera A, si es 11, 12 y 13, seran J, Q y K
                    {
                        card.Numero = "A";
                        card.Simbolo = tipoCarta;
                    }
                    else if (j > 10)
                    {
                        switch (j)
                        {
                            case 11:
                                card.Numero = "J";
                                card.Simbolo = tipoCarta;
                                break;
                            case 12:
                                card.Numero = "Q";
                                card.Simbolo = tipoCarta;
                                break;
                            case 13:
                                card.Numero = "K";
                                card.Simbolo = tipoCarta;
                                break;
                        }
                    }
                    else if (j>1 && j<=10)
                    {
                        card.Numero = j.ToString();
                        card.Simbolo = tipoCarta;
                    }
                    L.Add(card); //Lista en la que se ingresa el objeto que sale del ciclo
                }                
            }
            L = L.OrderBy(barajeo => rndm.Next()).ToList(); //Se revuelven las cartas dentro de la lista
            foreach (var card in L) //Se ingresar las cartas aleatoriamente ordenadas dentro de la pila
            {
                baraja.Push(card);
            }
        }

        public void DarCarta()   //Metodo para darle una carta nueva al jugador/usuario
        {
            numcartasMano++; //aumenta el numero de cartas que el jugador tiene
            //Se almacenan los valores de los atributos de las cartas en 2 variables
            numCarta = baraja.Peek().Numero; 
            simboloCarta = baraja.Peek().Simbolo;
            baraja.Pop(); //Se saca la carta de la pila (osea, se elimina de esta)
            Console.Write("{0}.- {1}{2} ", numcartasMano, numCarta, simboloCarta);
            if (numCarta == "A")//Condicion para dar el valor cuando la carta sea un A's
            {
                if (sumador + 11 < 21)
                {
                    Console.Write("Desea que el A's valga 1 u 11? ");
                    valorAs = int.Parse(Console.ReadLine());
                    switch (valorAs)
                    {
                        case 1:
                            sumador = sumador + 1;
                            break;
                        case 11:
                            sumador = sumador + 11;
                            break;
                    }
                }
                else if(sumador +11 ==21)
                {
                    sumador = sumador + 11;
                }
                else if (sumador + 11 > 21)
                {
                    sumador= sumador + 1;
                }
                
            }
            else if (numCarta == "J" || numCarta == "Q" || numCarta == "K") //Condicion para cuando la carta sea J, Q o K
            {
                sumador = sumador + 10;
            }
            else if (numCarta != "A" && numCarta != "J" && numCarta != "Q" && numCarta != "K") //Condicion para cuando la carta no sea A's, J, Q o K
            {
                sumador = sumador + int.Parse(numCarta);
            }
        }

        public void Record()//Metodo que muestra las veces que se ha ganado y las que se han perdido
        {
            Console.Clear();
            Console.WriteLine("Ganadas: {0}\tPerdidas: {1}", ganadas, perdidas);
            Console.ReadKey();

        }

        public void Comenzar() //Metodo que comienza el juego
        {
            //Resetea el numero de cartas en mano y la suma de las cartas
            sumador = 0; 
            numcartasMano = 0;
            int totaljuegos = perdidas + ganadas+1; // variable que muestra el numero de partida actual
            Console.Clear();
            Console.WriteLine("---PARTIDA #{0}", totaljuegos);
            Console.WriteLine("Cartas en mano: ");
            do //Ciclo que se repite mientras el jugador/usuario tenga menos de 5 cartas en la mano
            {
                if (sumador > 21) //Si el jugador/usuario tiene menos de 5 cartas y rebasa el 21, pierde
                {
                numcartasMano = 5; //Necesario para salir del ciclo
                }
                else if (sumador < 21) //Si el jugador/usuario aun no alcanza el 21 y tiene menos de 5 cartas en la mano, se le da otra carta
                {
                    DarCarta();
                    Console.WriteLine("suma de cartas: " + sumador);
                    Console.ReadKey();
                }
                else if (sumador == 21) //Si el jugador/usuario alcanza el 21 con 5 o menos cartas, gana
                {
                numcartasMano = 5; //Necesario para salir del ciclo
                }
            } while (numcartasMano < 5);

            if (numcartasMano == 5) //Condicion para cuando el jugador/usuario alcanza las 5 cartas
            {
                if (sumador > 21) //Si el sumador es mayor a 21, pierde
                {
                    perdidas++;
                    Console.WriteLine("Que mal, has perdido... \nGanadas: {0}\nPerdidas: {1}", ganadas, perdidas);
                    Console.WriteLine("\n\nDesea volver a jugar? (si/no)");
                    reinicio = Console.ReadLine(); //variable que lee si quiere jugar otra partida
                    if (reinicio == "si") 
                    {
                        opcion = false;
                    }
                    else
                    {
                        opcion = true;
                    }
                }
                else if(sumador <= 21) //Si el sumador es menor o igual a 21, gana
                {
                    ganadas++;
                    Console.WriteLine("Que bien! Has ganado, felicidades, enhorabuena, congratz, gg ...\nGanadas: {0}\nPerdidas: {1}", ganadas, perdidas);
                    Console.WriteLine("\n\nDesea volver a jugar? (si/no)");
                    reinicio = Console.ReadLine();
                    if (reinicio == "si") //Condicion para saber si el jugador/usuario quiere jugar otra ronda
                    {
                        opcion = false;
                    }
                    else
                    {
                        opcion = true;
                    }
                }
            }
            
        }

        public void Menu()
        {
            Console.WriteLine("------###Black Jack###-----");
            do { //Ciclo que se repite mientras que el jugador/usuario elija la opcion "3"
                CrearBaraja(); //Se crea la baraja
                Console.Clear();
                //Menu de opciones del juego
                Console.Write("Elija el numero de la opcion que desee:\n1.- Comenzar Juego Nuevo\n2.- Ver Estadisticas\n3.- Cerrar Programa\n----- ");
                opcionMenu = int.Parse(Console.ReadLine());
                switch (opcionMenu)
                {
                    case 1: //Si el jugador/usuario elige "1", se empieza un nuevo juego                       
                        Comenzar();
                        sumador = 0;
                        numcartasMano = 0;
                        if (opcion == false)
                        {
                            goto case 1;
                        }
                        break;
                    case 2: //Si el jugador/usuario elige "2", se miran las estadisticas (partidas ganadas y perdidas)
                        Record();
                        break;
                    case 3: //Si el jugador/usuario elige "3", se cierra el programa
                        Environment.Exit(0);
                        break;
                    default: //En caso de que el jugador/usuario, no ingrese ninguna de las opciones correctas
                        Console.WriteLine("Opcion no valida, intentelo otra vez");
                        Console.ReadKey();
                        break;
                }
            } while (opcionMenu >=0);
            Console.ReadKey();
        }
    }
}
