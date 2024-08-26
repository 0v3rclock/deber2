using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace deber2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escriba un programa que a partir de 
             * tres valores enteros pedidos al usuario 
             * calcule su suma y su media
             */
            Console.WriteLine("ingrese un valor entero");
            int numero1=int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro valor entero");
            int numero2=int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un tercer valor entero");
            int numero3=int.Parse(Console.ReadLine());
            int suma = numero1 + numero2 + numero3;
            double media = suma / 3;
            Console.WriteLine($"La suma es: {suma}. \n Mientras que la media es: {media}.");
            Thread.Sleep(2000);
            Console.ReadKey();
               
            }
    }
}
