using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);

            Console.WriteLine("Bienvenido al juego de adivinanza!");
            Console.WriteLine("Estoy pensando en un número entre 1 y 100.");

            while (true)
            {
                // Pedir al usuario que adivine el número
                Console.Write("Adivina el número: ");
                int adivinanza = Convert.ToInt32(Console.ReadLine());

                // Dar pista al usuario
                if (adivinanza < numeroSecreto)
                {
                    Console.WriteLine("El número que estoy pensando es mayor que " + adivinanza);
                }
                else if (adivinanza > numeroSecreto)
                {
                    Console.WriteLine("El número que estoy pensando es menor que " + adivinanza);
                }
                else
                {
                    Console.WriteLine("¡Felicidades! Has adivinado el número correcto: " + numeroSecreto);
                    break;
                }
            }

            Console.WriteLine("Gracias por jugar!");
            Thread.Sleep(10000);
        }
    }
}
