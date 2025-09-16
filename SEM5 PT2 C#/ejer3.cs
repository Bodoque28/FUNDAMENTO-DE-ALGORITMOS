using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM5_PT2_C_
{
    internal class ejer3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un monto de soles: ");
            double soles= double.Parse(Console.ReadLine());
            Console.WriteLine("\n Selecion una opcion: ");
            Console.WriteLine(" 1 DOLARES \n 2 EUROS ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:Console.WriteLine($"USD:  { (soles / 3.75):F2}");  break;
                case 2:Console.WriteLine($"EUROS: {(soles / 4.05):F2}");  break;
                default:Console.WriteLine("OPCION INCORRECTA");break;
            }
        }
    }
}
