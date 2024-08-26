using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número de día (1-7): ");
            int dia = int.Parse(Console.ReadLine());

            // Verificar que el número de día esté dentro del rango válido
            if (dia < 1 || dia > 7)
            {
                Console.WriteLine("Error: el número de día debe estar entre 1 y 7.");
                return;
            }

            // Asignar nombre del día según el número
            string nombreDia;
            switch (dia)
            {
                case 1:
                    nombreDia = "Lunes";
                    break;
                case 2:
                    nombreDia = "Martes";
                    break;
                case 3:
                    nombreDia = "Miércoles";
                    break;
                case 4:
                    nombreDia = "Jueves";
                    break;
                case 5:
                    nombreDia = "Viernes";
                    break;
                case 6:
                    nombreDia = "Sábado";
                    break;
                case 7:
                    nombreDia = "Domingo";
                    break;
                default:
                    nombreDia = "Error";
                    break;
            }

            // Mostrar resultado
            Console.WriteLine("El día correspondiente es: " + nombreDia);
            Thread.Sleep(10000);
        }
    }
}
