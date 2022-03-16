using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Ruleta
    {
        List<String> GIROS = new List<String>();
        List<int> valores = new List<int>();
        List<int>NumerosNegros = new List<int> {2,4,6,8,10,11,13,15,17,20,22,24,26,28,29,31,33,35};
        List<int> NumerosRojos = new List<int> { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };

        public static int  giros = 0, numeroMastirado = 0, numeroMenos = 0, ResultadoRoj = 0, ResultadoNeg = 0, Pares = 0, Impar = 0;


        public Ruleta()
        {

        }
        public void imprimirTablero(int dado)
        {
            Console.WriteLine("__________________________________________________________");
            Console.WriteLine("|                         Tablero                        |");
            Console.WriteLine("|________________________________________________________|");
            Console.Write("|NEGROS|");
            foreach (int a in NumerosNegros)
            {
                if (a == dado)
                {
                    Console.Write("x| ");
                }
                else
                {
                    Console.Write(a + "|");
                }
            }
            Console.WriteLine("");
            Console.Write("|ROJOS |");
            foreach (int i in NumerosRojos)
            {
                if (i == dado)
                {
                    Console.Write("x| ");
                }
                else
                {
                    Console.Write(i + "|");
                }
            }
            Console.Write("|");
            Console.WriteLine("");
            Console.WriteLine("|________________________________________________________|");

        }

        public int TirarDado()
        {
            Random r = new Random();

            int dado = r.Next(0, 37);

            EsPar(dado);
            EsBolaNegra(dado);
            return dado;
        }

        public void girar(int apuesta, int cantidad)
        {
            dinero Dinero = new dinero(300);
            int Dado = TirarDado();
            giros++;
  
            String String_Giros = ("Giro: " + giros + "Numero Caido: " +Dado);
            GIROS.Add(String_Giros);

            if(apuesta == 1)
            {
                Console.WriteLine("Ingrese el numero al cual apostar: ");
                int valor = int.Parse(Console.ReadLine());

                Console.WriteLine("Ruleta girando");
                imprimirTablero(Dado);
                Console.WriteLine("Bola cayo en numero: " + Dado);

                if (Dado == valor)
                {
                    Console.WriteLine("Felicidades ha ganado su apuesta ");
                    Dinero.Ganacia(10, cantidad, giros);
                }
                else
                {
                    Console.WriteLine("Suerte a la proxima  XD");
                    Dinero.Perdida(10, cantidad, giros);
                }

            }
            else if(apuesta == 2)
            {
                Console.WriteLine("Ingrese el color a apostar 1) Negro, 2) Rojo");
                int opcion = int.Parse(Console.ReadLine());
                if (Dado == 0) { Console.WriteLine("Valor dado: " + Dado); Console.WriteLine("La casa gana XD"); }
                else
                {
                    if (opcion == 1)
                    {
                        bool EsNegra = EsBolaNegra(Dado);
                        if (EsNegra == true)
                        {
                            imprimirTablero(Dado);
                            Console.WriteLine("Bola cayo en numero: " + Dado);
                            Console.WriteLine("Felicidades ha ganado su apuesta ");
                            Dinero.Ganacia(5, cantidad, giros);
                        }
                        else {
                            imprimirTablero(Dado);
                            Console.WriteLine("Bola cayo en numero: " + Dado); Console.WriteLine("Suerte a la proxima  XD");
                            Dinero.Perdida(10, cantidad, giros);
                        }
                    }
                    else if (opcion == 2)
                    {
                        bool EsNegra = EsBolaNegra(Dado);
                        if (EsNegra == false)
                        {
                            imprimirTablero(Dado);
                            Console.WriteLine("Bola cayo en numero: " + Dado);
                            Console.WriteLine("Felicidades ha ganado su apuesta ");
                            Dinero.Ganacia(5, cantidad, giros);
                        }
                        else {
                            imprimirTablero(Dado);
                            Console.WriteLine("Bola cayo en numero: " + Dado);
                            Console.WriteLine("Suerte a la proxima  XD");
                            Dinero.Perdida(5, cantidad, giros);
                        }
                    }
                }             

            }else if(apuesta == 3)
            {
                Console.WriteLine("Ingrese el color a apostar 1) Impar, 2) par");
                int opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    bool Par = EsPar(Dado);
                    if(Par == false)
                    {
                        imprimirTablero(Dado);
                        Console.WriteLine("Bola cayo en numero: " + Dado);
                        Console.WriteLine("Felicidades ha ganado su apuesta ");
                        Dinero.Ganacia(2, cantidad, giros);
                    }
                    else {
                        imprimirTablero(Dado);
                        Console.WriteLine("Bola cayo en numero: " + Dado);
                        Console.WriteLine("Suerte a la proxima  XD");
                        Dinero.Perdida(2, cantidad, giros);
                    }
                
                }else if(opcion == 2)
                {
                    bool Par = EsPar(Dado);
                    if (Par == true)
                    {
                        imprimirTablero(Dado);
                        Console.WriteLine("Bola cayo en numero: " + Dado);
                        Console.WriteLine("Felicidades ha ganado su apuesta ");
                        Dinero.Ganacia(2, cantidad, giros);
                    }
                    else {
                        imprimirTablero(Dado);
                        Console.WriteLine("Bola cayo en numero: " + Dado);
                        Console.WriteLine("Suerte a la proxima  XD");
                        Dinero.Perdida(2, cantidad, giros);
                    }
                }


            }
         
        }
        public bool EsPar(int valor)
        {
            bool Par = false;
            if ((valor % 2) ==0)
            {
                Par = true;
                Pares++;
            }
            else
            {
                Impar++;
            }
            return Par;
        }

        public bool EsBolaNegra(int valor)
        {
            bool BolaN = false;
            if (valor == 0){
                return false;
                
            }
            else
            {
                foreach(int i in NumerosNegros)
                {
                    if(i == valor)
                    {
                        ResultadoNeg++;
                        BolaN = true;
                        
                    }
                      
                }
                foreach(int a in NumerosRojos)
                {
                    if(a == valor)
                    {
                        ResultadoRoj++;
                                
                    }
                } 
            }
            
            return BolaN;
        }
        public void ImprimirGiros()
        {
            foreach(var i in GIROS)
            {
                Console.WriteLine(i);
            }
        }
        public void Estadistica()
        {
            Console.WriteLine("Cantidad de giros: " + giros);
            Console.WriteLine("Cantidad de resultados rojos: " + ResultadoRoj);
            Console.WriteLine("Cantidad de resultdos negros: " + ResultadoNeg);
            Console.WriteLine("Cantidad de resultados pares: " +Pares);
            Console.WriteLine("Cantidad de resultados Impares: " + Impar);
            ElementoRepetido();
        }
        public void ElementoRepetido()
        {
            bool repetidos = false;
            for(var x = 0; x< valores.Count; x++)
            {
                int a = valores[x];
                int c = x + 1;
                for(int y = c; y <valores.Count; y++)
                {
                    int b = valores[y];
                    if (a == b)
                    {
                        repetidos = true;
                        Console.WriteLine("Valor " + a + " es el mas repetido");
                    }
                    else
                    {
                        Console.WriteLine("No hay elementos que se hayan repetido");
                    }
                }
            }
        }
    }
}
