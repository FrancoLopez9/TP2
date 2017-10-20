using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico2
{
    /// <summary>
    /// Clase que representa un Triangulo
    /// </summary>
    public class Triangulo
    {
        //Atributos
        private Punto iPunto1;
        private Punto iPunto2;
        private Punto iPunto3;

        //Constructor
        /// <summary>
        /// Crea un Triangulo a partir de 3 puntos que son sus vertices
        /// </summary>
        /// <param name="pPunto1"> Primer vertice</param>
        /// <param name="pPunto2"> Segundo vertice</param>
        /// <param name="pPunto3"> Tercer vertice</param>
        public Triangulo(Punto pPunto1, Punto pPunto2, Punto pPunto3)
        {
            this.iPunto1 = pPunto1;
            this.iPunto2 = pPunto2;
            this.iPunto3 = pPunto3;
        }

        //Propiedades
        public Punto Punto1
        {
            get { return this.iPunto1; }
        }
        public Punto Punto2
        {
            get { return this.iPunto2; }
        }
        public Punto Punto3
        {
            get { return this.iPunto3; }
        }

        public double Area()
        {
            double ladoA = this.iPunto1.CalcularDistanciaDesde(this.iPunto2);
            double ladoB = this.iPunto2.CalcularDistanciaDesde(this.iPunto3);
            double ladoC = this.iPunto3.CalcularDistanciaDesde(this.iPunto1);
            double semiPerimetro = (ladoA + ladoB + ladoC) / 2;
            return Math.Sqrt(semiPerimetro * (semiPerimetro - ladoA) * (semiPerimetro - ladoB) * (semiPerimetro - ladoC));
        }

        public double Perimetro()
        {
            return this.iPunto1.CalcularDistanciaDesde(this.iPunto2) + this.iPunto1.CalcularDistanciaDesde(this.iPunto3) + this.iPunto2.CalcularDistanciaDesde(this.iPunto3);
        }
    }
}

