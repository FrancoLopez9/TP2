using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /// <summary>
    /// Clase que representa una Cuenta
    /// </summary>
    class Cuenta
    {
        //Atributos
        private double iSaldo;
        private double iAcuerdo;

        //Constructor
        /// <summary>
        /// Crea una Cuenta con un Acuerdo determinado
        /// </summary>
        /// <param name="pAcuerdo"> Acuerdo de la Cuenta</param>
        public Cuenta(double pAcuerdo)
        {
            this.iSaldo = 0;
            this.iAcuerdo = pAcuerdo;
        }

        /// <summary>
        /// Crea una Cuenta con un Saldo Inicial y Acuerdo determinado
        /// </summary>
        /// <param name="pSaldoInicial"> Saldo Inicial de la Cuenta</param>
        /// <param name="pAcuerdo"> Acuerdo de la Cuenta</param>
        public Cuenta(double pSaldoInicial, double pAcuerdo)
        {
            this.iSaldo = pSaldoInicial;
            this.iAcuerdo = pAcuerdo;
        }

        //Propiedades
        public double Saldo
        {
            get { return this.iSaldo; }
        }
        public double Acuerdo
        {
            get { return this.iAcuerdo; }
        }

        //Metodos
        /// <summary>
        /// Acredita Saldo en la Cuenta
        /// </summary>
        /// <param name="pSaldo"> Saldo a acreditar</param>
        public void AcreditarSaldo(double pSaldo)
        {
            iSaldo = Saldo + pSaldo;
        }

        /// <summary>
        /// Debita Saldo de la Cuenta
        /// </summary>
        /// <param name="pSaldo"> Saldo a debitar </param>
        /// <returns></returns>
        public Boolean DebitarSaldo(double pSaldo)
        {
            if (this.Saldo + this.Acuerdo < pSaldo)
            {
                return false;
            }
            else
            {
                iSaldo = this.Saldo - pSaldo;
                return true;
            }
        }
    }
}
