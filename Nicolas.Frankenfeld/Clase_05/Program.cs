using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta tintaUno = new Tinta();
            Tinta tintaDos = new Tinta();
            Pluma plumaUno = new Pluma("Pelikan", tintaUno);
            Pluma plumaDos = new Pluma("Pelikan", tintaUno);

            Console.WriteLine(Tinta.Mostrar(tintaUno));
            Console.WriteLine(Tinta.Mostrar(tintaDos));

            Console.WriteLine(Pluma.Mostrar(plumaUno));
            Console.WriteLine(Pluma.Mostrar(plumaDos));

            if(tintaUno==tintaDos)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son distintas");
            }
            Console.Write(tintaUno);
            //Console.Write((string)tintaUno);
            

        }
        

      

    }
}
