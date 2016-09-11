using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            double cuadrado = CalculoDeArea.CalcularCuadrado(45.2);
            double triangulo = CalculoDeArea.CalcularTriangulo(12, 15.2);
            double circulo = CalculoDeArea.CalcularCirculo(12.25);
            Console.WriteLine("Cuadrado:{0}\ntriagulo:{1}\nCirculo:{2}\n", cuadrado, triangulo, circulo);
        }
    }
}
