using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM5_PT2_C_
{
    internal class Ejer1

    {
        static void Main(string[] args)
        {
            Console.Write("DIGITE EDAD: ");
            int edad = int.Parse(Console.ReadLine());
            if (edad < 18)
            {
                Console.WriteLine("MENOR DE EDAD");
            }
            else
            {
                if (edad <= 64)
                {
                    Console.Write("Adulto");
                }
                else
                {
                    Console.Write("Adulto mayor");
                }
            }
        }
    }
}
