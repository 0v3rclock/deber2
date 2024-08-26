using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un numero");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro numero");
            int num2 =int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese a continuacion la operacion a realizar");
            string operacion = Console.ReadLine();
            int resultado = 0;
            switch (operacion) {
                case "+":
                    resultado =num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: no se puede dividir entre cero.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Error: operación no válida.");
                    return;
            }

            // Mostrar resultado
            Console.WriteLine("El resultado es: " + resultado);
            Thread.Sleep(10000);
        }
    }
    
}
