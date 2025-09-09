using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM_4_PT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer3();
        }
        static void ejer1()
        {
            Console.WriteLine("NOMBRE: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("CARRERA: ");
            string carrera = Console.ReadLine();
            Console.WriteLine($"\n {nombre}  bienvenido a mundo UPN en su carrera de  {carrera}  :v");

        }
        static void ejer2()
        {
            Console.WriteLine("\"EDUARDO\" ");
        }
        static void ejer3()
        {
            Console.Write("digite numero 1: ");
            int num1 =int.Parse(Console.ReadLine());
            Console.WriteLine("digite numero 2: ");
            int num2 = int.Parse(Console.ReadLine());
            double divi = (double)num1 / (double)num2;
            Console.WriteLine("SUMA: " + (num1 + num2));
            Console.WriteLine("RESTA: " + (num1 - num2));
            Console.WriteLine("MULTIPLICACION: " + (num1 * num2));
            Console.WriteLine("DIVISION: " + divi);
        }
        static void ejer4()
        {

        }
        static void ejer5()
        {

        }
        static void ejer6()
        {

        }
    }
}
