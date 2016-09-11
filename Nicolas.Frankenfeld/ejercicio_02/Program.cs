using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string linea;
            double numero, cuadrado, cubo;
            do
            {
                Console.WriteLine("ingrese el numero");
                linea = Console.ReadLine();
                double.TryParse(linea, out numero);
            } while (numero < 0);
            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);
            Console.WriteLine("Cuadrado: {0} Cubo: {1}", cuadrado, cubo);
        }
    }
}
