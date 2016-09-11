using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //copiado del ejercicio 03 sirve como base
            string linea;
            int numero, flag = 1, acumulador = 0;
            Console.WriteLine("Ingrese un numero");
            linea = Console.ReadLine();
            int.TryParse(linea, out numero);
            Console.Clear();
            for (int i = numero; i > 1; i--)
            {
                for (int j = i - 1; j >= 1; j--)
                {
                    if (i % j == 0)
                    {
                        acumulador += i;
                        flag = 0;
                    }
                }
                if (flag == 1)
                {
                    Console.WriteLine("{0}\t", i);
                }
                flag = 1;

            }

        }
    }
}
