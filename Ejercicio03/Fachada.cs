using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Fachada
    {
        public void MostrarPalabra(Letra[] pPalabra)
        {
            int pTope = pPalabra.Length;
            for (int value = 0; value < pTope; value++)
            {
                if (pPalabra[value].Descubierta)
                {
                    Console.Write(pPalabra[value].Caracter);
                } else
                {
                    Console.Write("*");
                }
            }
        } 
        public Letra[] ConvertirPalabra(string pPalabra)
        {
            char[] pArreglo = pPalabra.ToCharArray();
            Letra[] pArregloLetras = new Letra[pArreglo.Length];
            for (int value2 = 0; value2 < pArreglo.Length; value2++)
            {
                pArregloLetras[value2] = new Letra(pArreglo[value2], false);                
            }
            return pArregloLetras;
        }
        public string ObtenerPalabraRandom()
        {
            string[] pArreglo = { "atun", "aguila", "ballena", "caballo", "cabra", "camello", "cerdo", "cisne", "condor", "delfin", "elefante", "gallina",
                "gato", "hiena", "jirafa", "koala", "leon", "lobo", "loro", "ornitorrinco", "oso", "oveja", "pato", "perro", "pez", "rata", "rinoceronte", "tigre",
                "tortuga", "vaca" };
            Random random = new Random();
            int randomNumber = random.Next(0, 29);
            return pArreglo[randomNumber];
        }
        public Boolean ComprobarCaracter(char pCaracter, Letra[] pPalabra)
        {
            Boolean encontrado = false;
            for (int value3 = 0; value3 < pPalabra.Length; value3++)
            {
                if (pPalabra[value3].Caracter == pCaracter)
                {
                    pPalabra[value3].Descubierta = true;
                    encontrado = true;
                }
            }
            return encontrado;
        }
        public Boolean Victoria(Letra[] pPalabra)
        {
            Boolean pVictoria = true;
            for (int value4 = 0; value4 < pPalabra.Length; value4++)
            {
                if (pPalabra[value4].Descubierta == false)
                {
                    pVictoria = false;
                }
            }
            return pVictoria;
        }
        public Partida Jugar(double pIntentos)
        {
            string pPalabra = ObtenerPalabraRandom();
            Letra[] pPalabraLetra = ConvertirPalabra(pPalabra);
            Boolean pVictoria = false;
            Boolean pDerrota = false;
            Console.WriteLine("Ingresa tu nombre: ");
            string pJugador = Console.ReadLine();
            Console.WriteLine("\n A jugar!");
            DateTime pFechaInicio = DateTime.Now;
            while ((pVictoria == false) && (pDerrota == false))
            {
                Console.Write("\n La palabra a encontrar es: ");
                MostrarPalabra(pPalabraLetra);
                Console.WriteLine("\n Ingresa una letra:");
                char letra = Convert.ToChar(Console.ReadLine());
                if (ComprobarCaracter(letra, pPalabraLetra))
                {
                    Console.WriteLine("Muy bien! La letra forma parte de la palabra");
                } else
                {
                    pIntentos--;
                    Console.WriteLine("Esa letra no era parte de la palabra, te quedan {0} intentos",pIntentos);
                }
                if (pIntentos == 0)
                {
                    pDerrota = true;
                }
                pVictoria = Victoria(pPalabraLetra);
            }
            DateTime pFechaFinal = DateTime.Now;
            if (pVictoria)
            {
                Console.WriteLine("Felicidades! Has ganado la partida");
            } else
            {
                Console.WriteLine("Has perdido! Se te acabaron los intentos");
            }
            Console.ReadKey();
            return new Partida(pJugador, pFechaInicio, pFechaFinal, pVictoria);
        }
        public void Ranking(List<Partida> pListaPartidas)
        {
            List<Partida> pRanking = pListaPartidas.OrderBy(o => o.Duracion).ToList();
            var pI = pRanking.FindIndex(i => i.Resultado == false);
            if (pI >= 0) //Para asegurarse que encontro el elemento
            {   
                pRanking.RemoveAt(pI);
            }
            var pPrimerosCinco = pRanking.Take(5);
            List<Partida> pListaPrimerosCinco = pPrimerosCinco.ToList();
            pListaPrimerosCinco.ForEach(i => Console.Write("\n {0}, {1} hs {2} min {3} segs \t", i.Jugador, i.Duracion.Hours,i.Duracion.Minutes, i.Duracion.Seconds));
        }
    }
}
