using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el coeficiente a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el coeficiente b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el coeficiente c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            // Calcular el discriminante
            double discriminante = b * b - 4 * a * c;

            // Verificar si la ecuación tiene soluciones reales
            if (discriminante < 0)
            {
                Console.WriteLine("La ecuación no tiene soluciones reales.");
            }
            else
            {
                // Calcular las raíces
                double raiz1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                double raiz2 = (-b - Math.Sqrt(discriminante)) / (2 * a);

                // Mostrar resultados
                Console.WriteLine("La ecuación tiene dos soluciones reales:");
                Console.WriteLine("Raíz 1: " + raiz1);
                Console.WriteLine("Raíz 2: " + raiz2);
                Thread.Sleep(1000);
                Console.ReadKey();
            }
        }
    }
}
