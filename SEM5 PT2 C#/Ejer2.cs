using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM5_PT2_C_
{
    internal class Ejer2
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un año: ");
            int annio = int.Parse(Console.ReadLine());

            if (annio % 4 == 0 && annio % 100 != 0 || annio % 400 == 0)
            {
                Console.WriteLine("AÑO BISIESTO");
            }
            else
            {
                Console.WriteLine("AÑO NO BISIESTO");
            }
            if (annio % 2 == 0)
            {
                Console.WriteLine("AÑO PAR");
            }
            else
            {
                Console.WriteLine("AÑO IMPAR");
            }
        }
    }
}
