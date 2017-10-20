using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Letra
    {
        //Atributos
        private char iCaracter;
        private Boolean iDescubierta;

        //Constructores
        public Letra() {}
        public Letra(char pCaracter)
        {
            this.iCaracter = pCaracter;
            this.iDescubierta = false;
        }
        public Letra(char pCaracter, Boolean pDescubierta)
        {
            this.iCaracter = pCaracter;
            this.iDescubierta = pDescubierta;
        }

        //Propiedades
        public char Caracter
        {
            get { return this.iCaracter; }
            set { this.iCaracter = value; }
        }
        public Boolean Descubierta
        {
            get { return this.iDescubierta; }
            set { this.iDescubierta = value; }
        }


    }
}
