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
        
        /// <summary>
        /// constructor sin parametros
        /// </summary>
        public Numero()
        {
            this._numero = 0;
        }

        /// <summary>
        /// constructor con un parametro
        /// </summary>
        /// <param name="cadena">recibe el numero en tipo de dato string</param>
        public Numero(string cadena)
        {
            SetNumero(cadena);
        }

        /// <summary>
        /// constructo con un parametro 
        /// </summary>
        /// <param name="numero">recibe el numero con tipo de dato double</param>
        public Numero(double numero)
        {
            this._numero = numero;
        }

        /// <summary>
        /// valida a un numero que se pasa como string, si hay error retorna cero
        /// </summary>
        /// <param name="cadena">el string a ser convertido en double</param>
        /// <returns>un double si el parse es exitoso y en caso contrario un cero</returns>
        private double validarNumero(string cadena)
        {
            double numero;
            bool estaOk;
            estaOk = double.TryParse(cadena, out numero); 
            if(estaOk==true)
            {
                return numero;
            }
            else
            {
                numero = 0;
                return numero;
            }
        }

        /// <summary>
        /// setter de la variabel _numero
        /// </summary>
        /// <param name="cadena">string con el numero a validar </param>
        private void SetNumero(string cadena)
        {
            this._numero = validarNumero(cadena); 
        }

        /// <summary>
        /// get del _numero
        /// </summary>
        /// <returns>el numero contenido en _numero en tipo de dato double</returns>
        public double GetNumero()
        {
            return this._numero;
        }
    }
}
