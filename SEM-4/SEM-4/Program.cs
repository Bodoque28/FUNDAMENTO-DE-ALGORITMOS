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
            ejer1();
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
            Console.WriteLine("NUMERO DE HIJOS: ");
            int hijos = Convert.ToInt32(Console.ReadLine());
            switch(hijos)
            {case 0: boni = 0  ; break;
                case 1: boni = 0.05 * sue;break;
                case 2: boni = 0.1 * sue;break;
                default: boni = 0.15 * sue; break; }
            double suen = sue + boni;
            Console.WriteLine($"SUELDO : ${sue}");
            Console.WriteLine($"BONIFICACION : ${boni}");
            Console.WriteLine($"SUELDO NETO : ${suen}");
        }
        static void ejer1()
        {
            Console.Write("AÑOS DE TRABAJO: ");
            double años = Convert.ToDouble(Console.ReadLine());
            Console.Write("VENTA TOTALES: ");
            double venta = Convert.ToDouble(Console.ReadLine());
            Console.Write("NUMERO DE HIJOS: ");
            double hijos = Convert.ToDouble(Console.ReadLine());
            string boni = "no";
            if (años >= 3) { boni = "SI"; }
            if (venta>= 3500) { boni = "SI"; }
            if (hijos != 0) { boni = "SI"; }
            Console.WriteLine($"\n Usted {boni} recibe bonificacion ");
        }

    }

}
