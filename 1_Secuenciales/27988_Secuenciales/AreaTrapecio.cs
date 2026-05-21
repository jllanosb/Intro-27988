using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27988_Secuenciales
{
    internal class AreaTrapecio
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); // Fecha y Hora
            Console.WriteLine("Llanos Bardales, Jaime");
            Console.WriteLine("E1. Area Trapecio");
            
            //Declarar variables
            //Tipo dato nombre variable ;
            int bmayor, bmenor, altura;
            double area;

            //Entrada datos
            //Pedir al usuario con mensaje
            Console.WriteLine("Ingrese Base Mayor Trapecio");
            //Guardar el valor que ingresa el usuario
            //1ra Forma guardar
            bmayor=int.Parse(Console.ReadLine()); //int.parse
            Console.WriteLine("Ingrese Base Menor Trapecio");
            //2da Forma guardar
            bmenor=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese Altura Trapecio");
            //3ra Forma Forma Tryparse
            if (int.TryParse(Console.ReadLine(), out altura)){
                Console.WriteLine("Si es un numero se guardo");
                //Guardar el numero
             }
             else {
                   Console.WriteLine("El Valor ingresado no es un numero");
             }
             
            //Proceso
            area = (bmayor + bmenor) * altura / 2;

            //Salida datos
            Console.WriteLine($"El Area del Trapecio es: {area} m2");










        }
    }
}
