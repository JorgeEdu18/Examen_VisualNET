using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Menu
    {
        public Menu()
        {
            
            Console.WriteLine("Bienvienido al juego de la ruleta ");
            Console.WriteLine("Mucha suerte XD");
            
        }
       public void menu()
        {
            dinero Dinero = new dinero(300);
            Ruleta ruleta = new Ruleta();


            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("-------------------------------------------------------------------------------");
                Console.WriteLine("|                                   Menu             " +  "Dienero disponible: $"+   Dinero.MostrarDinero() +    " |");
                Console.WriteLine("|-----------------------------------------------------------------------------|");
                Console.WriteLine("| Apostar....................................................................1|");
                Console.WriteLine("| Estadisticas de juego......................................................2|");
                Console.WriteLine("| Historial de giros.........................................................3|");
                Console.WriteLine("| Balance dinero.............................................................4|");
                Console.WriteLine("| Ver tablero................................................................5|");
                Console.WriteLine("| Elementos repetidos........................................................6|");
                Console.WriteLine("| Salirse....................................................................0|");
                Console.WriteLine("|_____________________________________________________________________________|");
                Console.WriteLine("\n");
                Console.WriteLine("Elige la opcion a realizar");
                int opcion = int.Parse(Console.ReadLine());
                
                bool dinero = Dinero.TieneDinero();
                if (dinero != false)
                {
                    if (opcion == 1)
                    {

                        menuApostar();
                        Console.WriteLine("Elige la opcion a realizar");
                        int opcionApostar = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa la cantidad a apostar");
                        int cantidad = int.Parse(Console.ReadLine());
                        bool Multiplo10 = Dinero.Multiplo10(cantidad);
                        if (Multiplo10 == true)
                        {

                            if (opcionApostar == 1)
                            {
                                ruleta.girar(1, cantidad);
                            }
                            else if (opcionApostar == 2)
                            {
                                ruleta.girar(2, cantidad);
                            }
                            else if (opcionApostar == 3)
                            {
                                ruleta.girar(3, cantidad);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Cantidad no valida, debe ser un multiplo de diez, por favor reintenta de nuevo");
                        }
                    }
                    else if (opcion == 2)
                    {
                        ruleta.Estadistica();
                    }
                    else if(opcion == 3)
                    {
                        ruleta.ImprimirGiros();
                    }
                    else if( opcion == 4) { Dinero.imprimirResultados(); }
                    else if (opcion == 5) { ruleta.imprimirTablero(0); }
                    else if (opcion == 6) { ruleta.ElementoRepetido(); }
                    else if (opcion == 0) { salir = false; }
                }
                else
                {
                    Console.WriteLine("No tines dinero suficiente para jugar (dinero minimo para jugar $10)");
                    salir = false;
                    break;
                }
            }
        }
        public void menuApostar()
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("| Apuesta 1 (Numero especifico).............................1|");
            Console.WriteLine("| Apuesta 2 (Color especifico)..............................2|");
            Console.WriteLine("| Apuesta 3 (Numero par o impar)............................3|");
            Console.WriteLine("|____________________________________________________________|");
            Console.WriteLine("\n");
        }
    }
}

