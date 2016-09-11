using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1
{
    class Numero
    {
        private double _numero;
        
        public Numero()
        {
            this._numero = 0;
        }

        public Numero(string cadena)
        {
            SetNumero(cadena);
        }

        public Numero(double numero)
        {
            this._numero = numero;
        }

        private double validarNumero(string cadena)
        {
            double numero;
            if(double.TryParse(cadena, out numero)==true)
            {
                return numero;
            }
            else
            {
                numero = 0;
                return numero;
            }
        }


        private void SetNumero(string cadena)
        {
            this._numero = validarNumero(cadena); 
        }

        public double GetNumero()
        {
            return this._numero;
        }
    }
}
