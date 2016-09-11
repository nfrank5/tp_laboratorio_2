using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_14
{
    class CalculoDeArea
    {
        static public double CalcularCuadrado(double lado)
        {
            double areaCuadrado;
            areaCuadrado = lado * lado;
            return areaCuadrado;
        }
        static public double CalcularTriangulo(double baseTriangulo, double altura)
        {
            double areaTriangulo;
            areaTriangulo = (baseTriangulo * altura) / 2;

            return areaTriangulo;
        }
        static public double CalcularCirculo(double radio)
        {
            double areaCirculo;
            areaCirculo = Math.PI * (Math.Pow(radio, 2));
            return areaCirculo;
        }

    }
}
