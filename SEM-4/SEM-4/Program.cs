using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doble();
        }
        static void BASE()
        {
            Console.Write("digite sueldo : ");
            double sue = Convert.ToDouble(Console.ReadLine());
            double boni = 0.10 * sue;
            double suen = sue + boni;
            Console.WriteLine($"SUELDO : ${sue}");
            Console.WriteLine($"BONIFICACION : ${boni}");
            Console.WriteLine($"SUELDO NETO : ${suen}");

        }
        static void simple()
        {
            // SIMPLE
            Console.Write("digite sueldo : ");
            double sue = Convert.ToDouble(Console.ReadLine());
            double boni = 0;
            if (sue < 1000) { boni = 0.05 * sue; }
            if (sue >= 1000 && sue < 2000) { boni = 0.1 * sue; }
            if (sue >= 2000) { boni = 0.15 * sue; }
            double suen = sue + boni;
            Console.WriteLine($"SUELDO : ${sue}");
            Console.WriteLine($"BONIFICACION : ${boni}");
            Console.WriteLine($"SUELDO NETO : ${suen}");
        }
        static void doble()
        {
            //DOBLE
            Console.Write("digite sueldo : ");
            double sue = Convert.ToDouble(Console.ReadLine());
            double boni = 0;
            if (sue < 1000) { boni = 0.2 * sue; }
           else boni = 0.25 * sue;
                double suen = sue + boni;
            Console.WriteLine($"SUELDO : ${sue}");
            Console.WriteLine($"BONIFICACION : ${boni}");
            Console.WriteLine($"SUELDO NETO : ${suen}");

        }
        static void multiple()
        {
            //multiple
            Console.Write("digite sueldo : ");
            double sue = Convert.ToDouble(Console.ReadLine());
            double boni = 0;
            switch(sue)
            {case 0: boni = 0  ; break;
                case 1: boni = 0.05 * sue;break;
                case 2: boni = 0.1 * sue;break;
                default: boni = 0.15 * sue; break; }
            double suen = sue + boni;
            Console.WriteLine($"SUELDO : ${sue}");
            Console.WriteLine($"BONIFICACION : ${boni}");
            Console.WriteLine($"SUELDO NETO : ${suen}");
        }


    }

}
