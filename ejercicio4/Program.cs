using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pedir peso y altura al usuario
            Console.Write("Ingrese su peso en kilogramos: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese su altura en metros: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            // Calcular IMC
            double imc = peso / Math.Pow(altura, 2);

            // Clasificar estado de peso según IMC
            string estadoPeso;
            if (imc < 18.5)
            {
                estadoPeso = "Bajo peso";
            }
            else if (imc < 25)
            {
                estadoPeso = "Peso normal";
            }
            else if (imc < 30)
            {
                estadoPeso = "Sobrepeso";
            }
            else
            {
                estadoPeso = "Obesidad";
            }

            // Mostrar resultado
            Console.WriteLine("Su índice de masa corporal (IMC) es: " + imc.ToString("F2"));
            Console.WriteLine("Su estado de peso es: " + estadoPeso);
            Thread.Sleep(10000);
        }
    }
}
