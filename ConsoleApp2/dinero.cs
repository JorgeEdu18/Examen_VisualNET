using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class dinero
    {
        public int MontoInicial = 300;
        public static int MontoActual =300;
        private static List<string> BalanceDinero = new List<string>();
        public dinero(int inicial)
        {
            
        }

        public int MostrarDinero( )
        {
            return MontoActual;
        }
        public int Ganacia(int porciento, int apuesta, int giros)
        {
            int ganancia = porciento * apuesta;
            int TotalGanancia = MontoActual + ganancia;
            string valor = ("Ganancia de: " + ganancia + " en giro: " +giros);
            BalanceDinero.Add(valor);
            MontoActual = TotalGanancia;
            return MontoActual;
        }
        
        public int Perdida(int porciento, int apuesta, int giros)
        {
            int TotalPerdida = MontoActual - apuesta;
            string valor = ("Perdidas de: " + apuesta + " en giro: " +giros);
            BalanceDinero.Add(valor);
            MontoActual = TotalPerdida;
            return MontoActual;
        }
        public bool TieneDinero()
        {
            bool haydinero = false;
            if(MontoActual > 10)
            {
                haydinero = true;
            }
            return haydinero;
        }

        public void Balance()
        {
            if(MontoActual < MontoInicial)
            {
                int balance = MontoInicial - MontoActual;
                Console.WriteLine("Tienes una perdida de: " + balance);
            }
            else if(MontoActual > MontoInicial)
            {
                int balance = MontoActual - MontoInicial;
                Console.WriteLine("Tienes una Ganacia de: " + balance);
            }
            else if(MontoActual == MontoInicial)
            {
                Console.WriteLine("Tienes la misma cantidad: " + MontoActual);
            }
            
        }
        public bool Multiplo10(int valor)
        {
            bool esMultiplo = false;

            if(valor % 10 == 0)
            {
                esMultiplo = true;
            }
            return esMultiplo;
        }
        public void imprimirResultados()
        {
            foreach(var i in BalanceDinero)
            {
                Console.WriteLine(i);
            }
        }

        
    }
}
