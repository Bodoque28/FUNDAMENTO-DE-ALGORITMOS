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
            ejer4();
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
            Console.WriteLine("Ingrese un numero decimal: ");
            double num = double.Parse(Console.ReadLine());
            double raiz=Math.Sqrt(num);
            double redo = Math.Round(num,2);
            double cubo = Math.Pow(num,3);
            double raizcubica = Math.Pow(num,1/3d); 
            Console.WriteLine("Raiz cuaradada: " + raiz);
            Console.WriteLine("Redondeado: " + redo);
            Console.WriteLine("Elevado a 3: " + cubo);
            Console.WriteLine("Raiz cubica: " + raizcubica);
        }
        static void ejer5()
        {
            Console.WriteLine("Ingreese un numero: ");
            string num = Console.ReadLine();
            int entero = int.Parse(num);
            double deci=double.Parse(num);
            Console.WriteLine("Resto: " + (entero%2));
            Console.WriteLine("DECIMAL: " + (deci / 3));
        }
        static void ejer6()
        {

        }
    }
}
