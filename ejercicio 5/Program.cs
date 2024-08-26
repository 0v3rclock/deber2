using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la calificación numérica (0-100): ");
            int calificacion = int.Parse(Console.ReadLine());

            // Verificar que la calificación esté dentro del rango válido
            if (calificacion < 0 || calificacion > 100)
            {
                Console.WriteLine("Error: la calificación debe estar entre 0 y 100.");
                return;
            }

            // Asignar letra equivalente a la calificación
            string letra;
            if (calificacion >= 90)
            {
                letra = "A";
            }
            else if (calificacion >= 80)
            {
                letra = "B";
            }
            else if (calificacion >= 70)
            {
                letra = "C";
            }
            else if (calificacion >= 60)
            {
                letra = "D";
            }
            else
            {
                letra = "F";
            }

            // Mostrar resultado
            Console.WriteLine("La letra equivalente a la calificación es: " + letra);
            Thread.Sleep(10000);
        }
    }
}
