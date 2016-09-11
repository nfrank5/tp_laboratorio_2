using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05
{
    class Pluma
    {
        private string _marca;
        private Tinta _tinta;
        public Pluma()
        {
            this._marca = "sin marca";
            this._tinta = null;        
        }
        
        public Pluma(string marca):this()
        {
            this._marca = marca;
        }
        public Pluma(string marca,Tinta tinta): this(marca)
        {
            this._tinta = tinta;
        }
        private string Mostrar()
        {
            string dato = this._marca.ToString() + this._tinta.ToString();
            return dato;
        }
        static public string Mostrar(Pluma oPluma)
        {
            string dato = oPluma._marca.ToString() + oPluma._tinta.ToString();
            return dato;
        }

        
    }
}
