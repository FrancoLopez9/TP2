using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    public class Fecha //La clase toma al año como 360 dias, separados en 12 meses de 30 dias cada uno
    {
        //Atributos
        private TipoDia iDiaNombre;
        private double iDia;
        private double iMes;
        private double iAño;

        //Constructor
        public Fecha() { }
        public Fecha(TipoDia pDiaNombre, double pDia, double pMes, double pAño)
        {
            this.iDiaNombre = pDiaNombre;
            this.iDia = pDia;
            this.iMes = pMes;
            this.iAño = pAño;
        }

        //Propiedades
        public TipoDia DiaNombre
        {
            get { return this.iDiaNombre; }
            set { this.iDiaNombre = value; }
        }
        public double Dia
        {
            get { return this.iDia; }
            set { this.iDia = value; }
        }
        public double Mes
        {
            get { return this.iMes; }
            set { this.iMes = value; }
        }
        public double Año
        {
            get { return this.iAño; }
            set { this.iAño = value; }
        }

        //Metodos
        public TipoDia AumentarDiaNombre(TipoDia pDiaNombre)
        {
            TipoDia pSiguienteDia = new TipoDia();
            switch (pDiaNombre)
            {
                case TipoDia.LUNES:
                    pSiguienteDia = TipoDia.MARTES;
                    break;
                case TipoDia.MARTES:
                    pSiguienteDia = TipoDia.MIERCOLES;
                    break;
                case TipoDia.MIERCOLES:
                    pSiguienteDia = TipoDia.JUEVES;
                    break;
                case TipoDia.JUEVES:
                    pSiguienteDia = TipoDia.VIERNES;
                    break;
                case TipoDia.VIERNES:
                    pSiguienteDia = TipoDia.SABADO;
                    break;
                case TipoDia.SABADO:
                    pSiguienteDia = TipoDia.DOMINGO;
                    break;
                case TipoDia.DOMINGO:
                    pSiguienteDia = TipoDia.LUNES;
                    break;
            }
            return pSiguienteDia;
        }
        public void AgregarAños(double pAño)
        {
            AgregarDias(pAño * 360);
        }
        public void AgregarMeses(double pMes)
        {
            AgregarDias(pMes * 30);
        }
        public void AgregarDias(double pDias)
        {
            if (pDias > 0)
            {
                if (Mes == 12) //Fin de año
                {
                    if ((Dia + 1) > 30) //Fin de mes
                    {
                        DiaNombre = AumentarDiaNombre(DiaNombre);
                        Dia = 1;
                        Mes = 1;
                        Año = Año + 1;
                        AgregarDias(pDias - 1);
                    }
                    else
                    {
                        DiaNombre = AumentarDiaNombre(DiaNombre);
                        Dia = Dia + 1;
                        AgregarDias(pDias - 1);
                    }
                } else
                {
                    if ((Dia + 1) > 30) //Fin de mes
                    {
                        DiaNombre = AumentarDiaNombre(DiaNombre);
                        Dia = 1;
                        Mes = Mes + 1;
                        AgregarDias(pDias - 1);
                    }
                    else
                    {
                        DiaNombre = AumentarDiaNombre(DiaNombre);
                        Dia = Dia + 1;
                        AgregarDias(pDias - 1);
                    }
                }
            }
        }
        public Boolean EsBisiesto()
        {
            if((Año % 4) == 0)
                {
                if (((Año % 100) != 0) || ((Año % 400) == 0))
                {
                    return true;
                } else
                {
                    return false;
                }
            } else
            {
                return false;
            }
        }
        public Boolean Comparar(Fecha pFecha) //Devuelve verdadero si la fecha ingresada en el mensaje es mas reciente
        {
            if (pFecha.Año > Año)
            {
                return true;
            } else
            {
                if (pFecha.Año < Año)
                {
                    return false;
                } else
                {
                    if (pFecha.Mes > Mes)
                    {
                        return true;
                    } else
                    {
                        if (pFecha.Mes < Mes)
                        {
                            return false;
                        } else
                        {
                            if (pFecha.Dia > Dia)
                            {
                                return true;
                            } else
                            {
                                return false;
                            }
                        }
                    }
                }
            }
        }
    }
}
