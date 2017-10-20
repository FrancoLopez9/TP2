using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{

    class Program
    {
        static void Main(string[] args)
        {
            Fachada pFachada = new Fachada();
            Cuentas pCuentas = pFachada.CrearCuentaBase();
            Int16 pMenu1 = 15;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1 - Mostrar la información de mis cuentas.");
                Console.WriteLine("2 - Operar en Cuenta Corriente.");
                Console.WriteLine("3 - Operar en Caja de Ahorro.");
                Console.WriteLine("0 - Salir.");
                pMenu1 = Convert.ToInt16(Console.ReadLine());
                switch (pMenu1)
                {
                    case 1:
                        Console.WriteLine();
                        pFachada.MostrarCuentas(pCuentas);
                        break;
                    case 2:
                        Int16 pMenu2 = 15;
                        do
                        {
                            Console.WriteLine();
                            Console.WriteLine("Seleccione una opción:");
                            Console.WriteLine("1 - Mostrar Saldos de las Cuentas.");
                            Console.WriteLine("2 - Acreditar Saldo.");
                            Console.WriteLine("3 - Debitar Saldo.");
                            Console.WriteLine("4 - Transferir Saldo.");
                            Console.WriteLine("0 - Volver Atrás.");
                            pMenu2 = Convert.ToInt16(Console.ReadLine());
                            switch (pMenu2)
                            {
                                case 1:
                                    pFachada.MostrarSaldosDeCuentas(pCuentas);
                                    break;
                                case 2:
                                    pFachada.AcreditarSaldoCC(pCuentas);
                                    break;
                                case 3:
                                    pFachada.DebitarSaldoCC(pCuentas);
                                    break;
                                case 4:
                                    pFachada.TransferirSaldoDesdeCC(pCuentas);
                                    break;
                                case 0:
                                    // Salir
                                    break;
                            }
                        } while (pMenu2 != 0);
                        break;
                    case 3:
                        Int16 pMenu3 = 15;
                        do
                        {
                            Console.WriteLine();
                            Console.WriteLine("Seleccione una opción:");
                            Console.WriteLine("1 - Mostrar Saldos de las Cuentas.");
                            Console.WriteLine("2 - Acreditar Saldo.");
                            Console.WriteLine("3 - Debitar Saldo.");
                            Console.WriteLine("4 - Transferir Saldo.");
                            Console.WriteLine("0 - Volver Atrás.");
                            pMenu3 = Convert.ToInt16(Console.ReadLine());
                            switch (pMenu3)
                            {
                                case 1:
                                    pFachada.MostrarSaldosDeCuentas(pCuentas);
                                    break;
                                case 2:
                                    pFachada.AcreditarSaldoCA()
                                    break;
                                case 3:
                                    Console.WriteLine();
                                    Console.WriteLine("Ingrese el monto a debitar:");
                                    double pMonto2 = Convert.ToDouble(Console.ReadLine());
                                    if (pCuentas.CajaAhorro.DebitarSaldo(pMonto2))
                                    {
                                        Console.WriteLine("Se ha debitado $" + pMonto2 + " de la Cuenta.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Error! No queda Saldo suficiente para debitar ese monto.");
                                    }
                                    break;
                                case 4:
                                    Console.WriteLine();
                                    Console.WriteLine("Ingrese el monto a transferir:");
                                    double pMonto3 = Convert.ToDouble(Console.ReadLine());
                                    if (pCuentas.CajaAhorro.DebitarSaldo(pMonto3))
                                    {
                                        pCuentas.CuentaCorriente.AcreditarSaldo(pMonto3);
                                        Console.WriteLine("Se ha trasnferido $" + pMonto3 + " de la Cuenta a Cuenta Corriente.");

                                    }
                                    else
                                    {
                                        Console.WriteLine("Error! No queda Saldo suficiente para transferir ese monto.");
                                    }
                                    break;
                                case 0:
                                    // Salir
                                    break;
                            }
                        } while (pMenu3 != 0);
                        break;
                    case 0:
                        // Salir
                        break;
                }
            } while (pMenu1 != 0);
        }
    }
}