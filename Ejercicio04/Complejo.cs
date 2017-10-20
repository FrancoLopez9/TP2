using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    public class Complejo
    {
        //Atributos
        private double iReal;
        private double iImaginario;

        //Constructor
        public Complejo() { }
        public Complejo(double pReal, double pImaginario)
        {
            this.iReal = pReal;
            this.iImaginario = pImaginario;
        }
        
        //Propiedades (sin set o con set en privado para que sea inmutable)
        public double Real
        {
            get { return this.iReal; }
            private set { this.iReal = value; }
        }
        public double Imaginario
        {
            get { return this.iImaginario; }
            private set { this.iImaginario = value; }
        }
        public double ArgumentoEnRadianes
        {
            get { return Math.Atan(Imaginario / Real); }
        }
        public double ArgumentoEnGrados
        {
            get { return (180 * Math.Atan(Imaginario / Real)) / Math.PI; }
        }
        public Complejo Conjugado()
        {
            Complejo pConjugado = new Complejo();
            pConjugado.Real = Real;
            pConjugado.Imaginario = Imaginario;
            return pConjugado;
        }
        public double Magnitud
        {
            get { return Math.Sqrt(Math.Pow(Real, 2) + Math.Pow(Imaginario, 2)); }
        }

        //Metodos
        public Boolean EsReal()
        {
            return (Imaginario == 0);
        }
        public Boolean EsImaginario()
        {
            return (Real == 0);
        }
        public Boolean EsIgual(Complejo pOtroComplejo)
        {
            return (Real == pOtroComplejo.Real) && (Imaginario == pOtroComplejo.Imaginario);
        }
        public Boolean EsIgual(double pReal, double pImaginario)
        {
            return (Real == pReal) && (Imaginario == pImaginario);
        }
        public Complejo Sumar(Complejo pOtroComplejo)
        {
            Complejo pSumado = new Complejo();
            pSumado.Real = Real + pOtroComplejo.Real;
            pSumado.Imaginario = Imaginario + pOtroComplejo.Imaginario;
            return pSumado;
        }
        public Complejo Restar(Complejo pOtroComplejo)
        {
            Complejo pRestado = new Complejo();
            pRestado.Real = Real - pOtroComplejo.Real;
            pRestado.Imaginario = Imaginario - pOtroComplejo.Imaginario;
            return pRestado;
        }
        public Complejo MultiplicarPor(Complejo pOtroComplejo)
        {
            Complejo pMultiplicado = new Complejo();
            pMultiplicado.Real = Real * pOtroComplejo.Real;
            pMultiplicado.Imaginario = Imaginario * pOtroComplejo.Imaginario;
            return pMultiplicado;
        }
        public Complejo DividirPor(Complejo pOtroComplejo)
        {
            Complejo pDividido = new Complejo();
            pDividido.Real = Real / pOtroComplejo.Real;
            pDividido.Imaginario = Imaginario / pOtroComplejo.Imaginario;
            return pDividido;
        }
    }

}
