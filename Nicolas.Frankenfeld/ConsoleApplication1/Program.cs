using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string linea;
            int numero = 0, maximo = 0, minimo = 0, promedio = 0, contador = 0, acumulador = 0;
            for (int i = 0; i < 5; i++)
            {
                linea = Console.ReadLine();
                if (int.TryParse(linea, out numero))
                {

                    if (contador == 0)
                    {
                        minimo = numero;
                        maximo = numero;
                        acumulador = numero;
                    }
                    else
                    {
                        if (numero < minimo)
                        {
                            minimo = numero;
                        }
                        if (numero > maximo)
                        {
                            maximo = numero;
                        }
                        acumulador += numero;
                    }
                    contador++;
                    //              Console.WriteLine("{0}\n",numero);

                }
                else
                {
                    Console.WriteLine("No es un entero");
                }
            }
            promedio = acumulador / contador;
            Console.WriteLine("maximo{0}  minimo{1} promedio  {2}", maximo, minimo, promedio);


        }
    }
}
