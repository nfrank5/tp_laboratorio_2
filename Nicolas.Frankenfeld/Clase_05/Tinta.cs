using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05
{
    class Tinta
    {

        private ConsoleColor _Color;
        private ETipotinta _Tipo;

        public Tinta()
        {
            this._Color = ConsoleColor.Black;
            this._Tipo = ETipotinta.Comun;
        }

        public Tinta(ConsoleColor Color):this()
        {
            this._Color = Color;
        }
        public Tinta(ConsoleColor Color, ETipotinta Tipo): this(Color)
        {
            this._Tipo = Tipo;
        }
        private string Mostrar()
        {
            string dato = this._Color.ToString() + this._Tipo.ToString(); 
            return dato;

        }
        static public string Mostrar(Tinta etiqueta)
        {
            string dato = etiqueta._Color.ToString()+etiqueta._Tipo.ToString();
            return dato;
        }

        /*
        public static bool operator == (Tinta t1, Tinta t2)
        {
            bool respuesta = false;
            if (t1._Color == t2._Color && t1._Tipo == t2._Tipo)
            {
                respuesta = true;
            }
            return respuesta;
        }*/
        /*public static bool operator != (Tinta t1, Tinta t2)
        {

            return !(t1 == t2);
        }*/
        /*
        public static bool operator ==(Tinta t1, Tinta t2)
        {
            bool respuesta = false;
            if (t1._Color == t2._Color && t1._Tipo == t2._Tipo)
            {
                respuesta = true;
            }
            return respuesta;
        }*/
        //public static operatorstring(Tinta t)
         


    }
}
