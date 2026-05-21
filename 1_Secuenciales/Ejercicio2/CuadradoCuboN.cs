using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class CuadradoCuboN
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); // Fecha y Hora
            Console.WriteLine("Llanos Bardales, Jaime");
            Console.WriteLine("E1. Numero al Cuadrado y Cubo"); 
            int n, cuadrado, cubo;
            Console.WriteLine("Ingrese un numero");
            n=int.Parse(Console.ReadLine());
            cuadrado = n * n;
            cubo = n * n * n;
            Console.WriteLine($"El cuadrado de {n} es : {cuadrado}");
            Console.WriteLine($"El cubo de {n} es: {cubo}");
        }
    }
}
