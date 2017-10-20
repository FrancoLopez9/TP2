using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione una opcion para la forma geometrica:");
            Console.WriteLine("1 - Circulo");
            Console.WriteLine("2 - Triangulo");
            Console.WriteLine("0 - Salir");
            Fachada fachada = new Fachada();
            switch (Convert.ToInt16(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Ingrese el valor de X:");
                    double x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor de Y:");
                    double y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor del radio:");
                    double radio = Convert.ToDouble(Console.ReadLine());
                    double perimetro = fachada.CalcularPerimetroCirculo(x, y, radio);
                    double area = fachada.CalcularAreaCirculo(x, y, radio);
                    Console.WriteLine("El perimetro del circulo es: " + perimetro);
                    Console.WriteLine("El área del circulo es: " + area);
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Ingrese el valor de X del primer punto:");
                    double x1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor de Y del primer punto:");
                    double y1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor de X del segundo punto:");
                    double x2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor de Y del segundo punto:");
                    double y2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor de X del tercer punto:");
                    double x3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor de Y del tercer punto:");
                    double y3 = Convert.ToDouble(Console.ReadLine());
                    double perimetroT = fachada.CalcularPerimetroTriangulo(x1, y1, x2, y2, x3, y3);
                    double areaT = fachada.CalcularAreaTriangulo(x1, y1, x2, y2, x3, y3);
                    Console.WriteLine("El perimetro del triangulo es:" + perimetroT);
                    Console.WriteLine("El área del triangulo es: " + areaT);
                    Console.ReadKey();
                    break;
                case 0:
                    break;
            }
            Console.ReadKey();
        }   
    }
}
