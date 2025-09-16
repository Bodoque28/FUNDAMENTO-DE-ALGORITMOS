using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM_5_PT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite numero de fin: ");
            int fin = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite numero de inicio: ");
            int inicio = int.Parse(Console.ReadLine());
            int sumai = 0;
            int cani = 0;
            
            for (int i = fin;i >= inicio; i--) {
                Console.Write(i+" ");
                if (i % 2 ==1)
                {
                    sumai += i;
                    cani++;
                }
            } 
            Console.WriteLine("El promedio de los numeros impares es: "+(sumai/cani));

        }
        static void ejer1()
        {
            int n_m_pago, cant, n_t_tarjeta;
            double t_pagar, des = 0, incremento = 0, m_pagar;

            Console.Write("TOTAL A PAGAR: ");
            t_pagar = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\nMETODO DE PAGO\n 1.efectivo \n 2.tarjeta \n 3.transferencia \n");
            n_m_pago = Convert.ToInt32(Console.ReadLine());

            switch (n_m_pago)
            {
                case 1: des = 0.07 * t_pagar; break;
                case 2:
                    Console.WriteLine($"TIPO DE TARJETA:\n 1. debito \n 2 credito ");
                    n_t_tarjeta = Convert.ToInt32(Console.ReadLine());
                    switch (n_t_tarjeta)
                    {
                        case 1:
                            Console.WriteLine("CANTIDAD DE PRODUCTOS: ");
                            cant = Convert.ToInt32(Console.ReadLine());
                            if (cant > 10)
                                des = 0.05 * t_pagar;
                            break;
                        case 2: incremento = 0.05 * t_pagar; break;
                    }
                    break;
                case 3:
                    if (t_pagar == 100)
                        des = 10;
                    break;
                default: Console.WriteLine("NUMERO INCORRECTO"); break;
            }

            m_pagar = t_pagar + incremento - des;

            Console.WriteLine("TOTAL: $" + t_pagar);
            if (des != 0)
                Console.WriteLine("DESCUENTO: $" + des);
            else Console.WriteLine("INDREMENTO: $" + incremento);
            Console.WriteLine("MONTO TOTAL: $" + m_pagar);
        }
    }   

}
