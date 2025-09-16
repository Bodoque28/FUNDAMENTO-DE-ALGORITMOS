using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM5_PT2_C_
{
    internal class Ejer4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos al calculo de areas\n 1. cuadrado \n 2 rectangulo \n 3 triangulo \n 4 ciculo \nIngrese una opcion: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:Console.WriteLine("Ingrese un lado: ");
                    int lado = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nArea: " + (lado * lado));
                    break;
                case 2:Console.WriteLine("Ingrese base: "); 
                    int bse =int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese altura: ");
                    int alt = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n Area: "+(bse * alt)); 
                    break;
                case 3: Console.WriteLine("Ingrese base: ");
                    int bse2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese altura: ");
                    int alt2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n Area: " + (bse2 * alt2) / 2); break;
                case 4:Console.WriteLine("Ingrese Radio: ");
                    double rad = double.Parse(Console.ReadLine());
                    Console.WriteLine("Area: " + Math.Round(Math.PI * Math.Pow(rad,2),2));
                    break;
                default: Console.WriteLine("NUMERO INCORRECTO"); break;
            }
        }
    } 
}
