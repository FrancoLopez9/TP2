using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /// <summary>
    /// Clase que representa la relacion entre el Cliente y sus Cuentas
    /// </summary>
    class Cuentas
    {
        //Atributos
        private Cliente iCliente;
        private Cuenta iCajaAhorro;
        private Cuenta iCuentaCorriente;

        //Constructores
        public Cuentas() { }
        /// <summary>
        /// Crea una relacion del Cliente con sus Cuentas
        /// </summary>
        /// <param name="pCliente"> Cliente</param>
        /// <param name="pCajaAhorro"> Caja de Ahorro del Cliente</param>
        /// <param name="pCuentaCorriente"> Cuenta Corriente del Cliente</param>
        public Cuentas(Cliente pCliente, Cuenta pCajaAhorro, Cuenta pCuentaCorriente)
        {
            iCliente = pCliente;
            iCajaAhorro = pCajaAhorro;
            iCuentaCorriente = pCuentaCorriente;
        }

        //Propiedades
        public Cliente Cliente
        {
            get { return this.iCliente; }
        }
        public Cuenta CuentaCorriente
        {
            get { return this.iCuentaCorriente; }
        }
        public Cuenta CajaAhorro
        {
            get { return this.iCajaAhorro; }
        }
    }
}
