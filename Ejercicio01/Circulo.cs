using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico2
{
    /// <summary>
    /// Clase que representa la figura geometrica Circulo
    /// </summary>
    public class Circulo
    {
        //Atributos
        private double iRadio;
        private Punto iCentro;

        //Constructor
        /// <summary>
        /// Crea un Circulo a partir de un punto y un radio
        /// </summary>
        /// <param name="pCentro"> Punto que representa el Centro del Circulo</param>
        /// <param name="pRadio"> Radio del Ciculo</param>
        public Circulo(Punto pCentro, double pRadio)
        {
            this.iCentro = pCentro;
            this.iRadio = pRadio;
        }
        /// <summary>
        /// Crea un Circulo a partir de las coordenadas XY de un punto y un radio
        /// </summary>
        /// <param name="pX"> valor x del centro</param>
        /// <param name="pY"> valor y del centro</param>
        /// <param name="pRadio"> radio del cirbulo</param>
        public Circulo(double pX, double pY, double pRadio)
        {
            this.iCentro = new Punto(pX, pY);
            this.iRadio = pRadio;
        }

        //Propiedades
        public Punto Centro
        {
            get { return this.iCentro; }
        }
        public double Radio
        {
            get { return this.iRadio; }
        }
        public double Area
        {
            get { return (Math.PI * Math.Pow(this.iRadio, 2)); }
        }
        public double Perimetro
        {
            get { return 2 * Math.PI * this.iRadio; }
        }
    }
 }
