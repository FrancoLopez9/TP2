using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico2
{
    /// <summary>
    /// Clase que representa el Controlador de Fachada
    /// </summary>
    class Fachada
    {
        /// <summary>
        /// Devuelve el Perimetro de un triangulo
        /// </summary>
        /// <param name="pX1"> Coordenada X del primer Vertice</param>
        /// <param name="pY1"> Coordenada Y del primer Vertice</param>
        /// <param name="pX2"> Coordenada X del segundo Vertice</param>
        /// <param name="pY2"> Coordenada Y del segundo Vertice</param>
        /// <param name="pX3"> Coordenada X del tercer Vertice</param>
        /// <param name="pY3"> Coordenada Y del tercer Vertice</param>
        /// <returns></returns>
        public double CalcularPerimetroTriangulo(double pX1, double pY1, double pX2, double pY2, double pX3, double pY3)
        {
            Punto punto1 = new Punto(pX1, pY1);
            Punto punto2 = new Punto(pX2, pY2);
            Punto punto3 = new Punto(pX3, pY3);
            Triangulo triangulo = new Triangulo(punto1, punto2, punto3);
            return triangulo.Perimetro();
        }

        /// <summary>
        /// Devuelve el Area de un Triangulo
        /// </summary>
        /// <param name="pX1"> Coordenada X del primer vertice</param>
        /// <param name="pY1"> Coordenada Y del primer vertice</param>
        /// <param name="pX2"> Coordenada X del segundo vertice</param>
        /// <param name="pY2"> Coordenada Y del segundo vertice</param>
        /// <param name="pX3"> Coordenada X del tercer vertice</param>
        /// <param name="pY3"> Coordenada Y del tercer vertice</param>
        /// <returns></returns>
        public double CalcularAreaTriangulo(double pX1, double pY1, double pX2, double pY2, double pX3, double pY3)
        {
            Punto punto1 = new Punto(pX1, pY1);
            Punto punto2 = new Punto(pX2, pY2);
            Punto punto3 = new Punto(pX3, pY3);
            Triangulo triangulo = new Triangulo(punto1, punto2, punto3);
            return triangulo.Area();
        }

        /// <summary>
        /// Devuelve el perimetro de un Circulo
        /// </summary>
        /// <param name="pX"> Coordenada X del Centro</param>
        /// <param name="pY"> Coordenada Y del Centro</param>
        /// <param name="pRadio"> Radio del Circulo</param>
        /// <returns></returns>
        public double CalcularPerimetroCirculo(double pX, double pY, double pRadio)
        {
            Punto punto = new Punto(pX, pY);
            Circulo circulo = new Circulo(punto, pRadio);
            return circulo.Perimetro;
        }

        /// <summary>
        /// Devuelve el Area de Circulo
        /// </summary>
        /// <param name="pX"> Coordenada X del Centro </param>
        /// <param name="pY"> Coordenada Y del Centro </param>
        /// <param name="pRadio"> Radio del Circulo </param>
        /// <returns></returns>
        public double CalcularAreaCirculo(double pX, double pY, double pRadio)
        {
            Punto punto = new Punto(pX, pY);
            Circulo circulo = new Circulo(punto, pRadio);
            return circulo.Area;
        }
    }
}
