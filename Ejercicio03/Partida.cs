using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Partida
    {
        //Atributos
        private string iJugador;
        private DateTime iFechaInicio;
        private DateTime iFechaFinal;
        private Boolean iResultado;

        //Constructores
        public Partida() { }
        public Partida(string pJugador, DateTime pFechaInicio, DateTime pFechaFinal, Boolean pResultado)
        {
            this.iJugador = pJugador;
            this.iFechaInicio = pFechaInicio;
            this.iFechaFinal = pFechaFinal;
            this.iResultado = pResultado;
        }

        //Propiedades
        public string Jugador
        {
            get { return this.iJugador; }
            set { this.iJugador = value; }
        }
        public DateTime FechaInicio
        {
            get { return this.iFechaInicio; }
            set { this.iFechaInicio = value; }
        }
        public DateTime FechaFinal
        {
            get { return this.iFechaFinal; }
            set { this.iFechaFinal = value; }
        }
        public Boolean Resultado
        {
            get { return this.iResultado; }
            set { this.iResultado = value; }
        }
        public TimeSpan Duracion
        {
            get { return FechaFinal.Subtract(FechaInicio); }
        }
        
    }


}
