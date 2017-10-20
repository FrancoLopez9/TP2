using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico2
{
    /// <summary>
    /// Clase que reprensa un Punto
    /// </summary>
    public class Punto
    {
        //Atributos
        private double iX;
        private double iY;

        //Constructor
        /// <summary>
        /// Crea un Punto a partir de las coordenadas XY
        /// </summary>
        /// <param name="pX"> Coordenadas X del Punto</param>
        /// <param name="pY"> Coordenadas Y del Punto</param>
        public Punto(double pX, double pY)
        {
            this.iX = pX;
            this.iY = pY;
        }


        //Propiedades
        public double X
        {
            get { return this.iX; }
        }
        public double Y
        {
            get { return this.iY; }
        }

        //Metodos
        /// <summary>
        /// Devuelve la distancia entre este Punto y otro
        /// </summary>
        /// <param name="pPunto"> Punto de referencia para calcular la distancia</param>
        /// <returns></returns>
        public double CalcularDistanciaDesde(Punto pPunto)
        {
            return Math.Sqrt(Math.Pow(this.X - pPunto.X, 2) + Math.Pow(this.Y - pPunto.Y, 2));
        }
    }
}

