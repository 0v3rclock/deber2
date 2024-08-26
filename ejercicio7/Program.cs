using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal saldo = 1000.00m;

            Console.WriteLine("Bienvenido al cajero automático!");
            Console.WriteLine("Su saldo actual es: $" + saldo);

            while (true)
            {
                // Pedir cantidad a retirar
                Console.Write("Ingrese la cantidad que desea retirar: $");
                decimal cantidad = Convert.ToDecimal(Console.ReadLine());

                // Verificar si la cantidad es válida
                if (cantidad <= 0)
                {
                    Console.WriteLine("Error: la cantidad debe ser mayor que cero.");
                    continue;
                }

                // Verificar si tiene saldo suficiente
                if (cantidad > saldo)
                {
                    Console.WriteLine("Error: no tiene saldo suficiente.");
                    continue;
                }

                // Realizar la operación y actualizar el saldo
                saldo -= cantidad;
                Console.WriteLine("Operación realizada con éxito.");
                Console.WriteLine("Su nuevo saldo es: $" + saldo);

                // Preguntar si desea realizar otra operación
                Console.Write("¿Desea realizar otra operación? (s/n): ");
                string respuesta = Console.ReadLine();
                if (respuesta.ToLower() != "s")
                {
                    break;
                }
            }

            Console.WriteLine("Gracias por utilizar nuestro cajero automático.");
            Thread.Sleep(10000);
        }
    }
}
