using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /// <summary>
    /// Clase que representa el Controlador de Fachada
    /// </summary>
    class Fachada
    {
        /// <summary>
        /// Crea una Cuenta y Cliente con valores iniciales
        /// </summary>
        /// <returns></returns>
        public Cuentas CrearCuentaBase()
        {
            Cliente pCliente = new Cliente(TipoDocumento.DNI, "12345678", "Juan Perez");
            Cuenta pCuentaCorriente = new Cuenta(100);
            Cuenta pCajaAhorro = new Cuenta(20, 200);
            Cuentas pCuentas = new Cuentas(pCliente, pCajaAhorro, pCuentaCorriente);
            return pCuentas;
        }

        /// <summary>
        /// Muestra toda la informacion asociada a un Cliente y sus Cuentas
        /// </summary>
        /// <param name="pCuentas"></param>
        public void MostrarCuentas(Cuentas pCuentas) 
        {
            Console.WriteLine("Los datos son los siguientes:");
            Console.WriteLine("Nombre del Cliente: " + pCuentas.Cliente.Nombre);
            Console.WriteLine("Numero de documento del Cliente: " + pCuentas.Cliente.NroDocumento);
            Console.WriteLine("Saldo de la caja de ahorro: " + pCuentas.CajaAhorro.Saldo);
            Console.WriteLine("Acuerdo de la caja de ahorro: " + pCuentas.CajaAhorro.Acuerdo);
            Console.WriteLine("Saldo de la cuenta corriente: " + pCuentas.CuentaCorriente.Saldo);
            Console.WriteLine("Acuerdo de la cuenta corriente: " + pCuentas.CuentaCorriente.Acuerdo);
        }

        /// <summary>
        /// Muestra los saldos de las cuentas del Cliente
        /// </summary>
        /// <param name="pCuentas"> Cuentas del Cliente</param>
        public void MostrarSaldosDeCuentas(Cuentas pCuentas)
        {
            Console.Clear();
            Console.WriteLine("El saldo de esta cuenta es: $" + pCuentas.CuentaCorriente.Saldo);
            Console.WriteLine("El saldo de la Caja de Ahorro es: $" + pCuentas.CajaAhorro.Saldo);
        }

        /// <summary>
        /// Acredita en la Cuenta Corriente del Cliente
        /// </summary>
        /// <param name="pCuentas"> Cuentas del Cliente </param>
        public void AcreditarSaldoCC(Cuentas pCuentas)
        {
            Console.Clear();
            Console.WriteLine("Ingrese el monto a acreditar:");
            double pMonto = Convert.ToDouble(Console.ReadLine());
            pCuentas.CuentaCorriente.AcreditarSaldo(pMonto);
            Console.WriteLine("Se ha acreditado $" + pMonto + " en la Cuenta.");
        }

        /// <summary>
        /// Acredita en la Caja de Ahorro del CLiente
        /// </summary>
        /// <param name="pCuentas"> Cuentas del Cliente </param>
        public void AcreditarSaldoCA(Cuentas pCuentas)
        {
            Console.Clear();
            Console.WriteLine("Ingrese el monto a acreditar:");
            double pMonto = Convert.ToDouble(Console.ReadLine());
            pCuentas.CajaAhorro.AcreditarSaldo(pMonto);
            Console.WriteLine("Se ha acreditado $" + pMonto + " en la Cuenta.");
        }

        /// <summary>
        /// Debita en la Cuenta Corriente del Cliente
        /// </summary>
        /// <param name="pCuentas"> Cuentas del Cliente </param>
        public void DebitarSaldoCC(Cuentas pCuentas)
        {
            Console.Clear();
            Console.WriteLine("Ingrese el monto a debitar:");
            double pMonto2 = Convert.ToDouble(Console.ReadLine());
            if (pCuentas.CuentaCorriente.DebitarSaldo(pMonto2))
            {
                Console.WriteLine("Se ha debitado $" + pMonto2 + " de la Cuenta.");
            }
            else
            {
                Console.WriteLine("Error! No queda Saldo suficiente para debitar ese monto.");
            }
        }



        /// <summary>
        /// Transfiere un monto desde la Cuenta Corriente a la Caja de ahorro
        /// </summary>
        /// <param name="pCuentas"> Cuentas del Cliente </param>
        public void TransferirSaldoDesdeCC(Cuentas pCuentas)
        {
            Console.Clear();
            Console.WriteLine("Ingrese el monto a transferir:");
            double pMonto3 = Convert.ToDouble(Console.ReadLine());
            if (pCuentas.CuentaCorriente.DebitarSaldo(pMonto3))
            {
                pCuentas.CajaAhorro.AcreditarSaldo(pMonto3);
                Console.WriteLine("Se ha trasnferido $" + pMonto3 + " de la Cuenta a Caja de Ahorro.");

            }
            else
            {
                Console.WriteLine("Error! No queda Saldo suficiente para transferir ese monto.");
            }
        }

    }
}
