using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Fachada pFachada = new Fachada();
            double pIntentos = 10; //Cantidad base de intentos
            List<Partida> pListaPartidas = new List<Partida>();
            Int16 menu = 9;
            while (menu != 0)
            {
                Console.WriteLine("\n Juego del ahorcado \n Seleccione una de las siguientes opciones: \n 1. Jugar \n 2. Ranking \n 3. Ajustar la dificultad \n 0. Salir");
                menu = Convert.ToInt16(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Partida pPartida = pFachada.Jugar(pIntentos);
                        pListaPartidas.Add(pPartida);
                        break;
                    case 2:
                        Console.WriteLine("\n Este es el ranking de los mejores 5 jugadores: \n");
                        pFachada.Ranking(pListaPartidas);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("\n Ingrese el numero de intentos que desea tener:");
                        pIntentos = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\n Ahora tiene {0} intentos.", pIntentos);
                        break;
                }
            }
       }
    }
}
