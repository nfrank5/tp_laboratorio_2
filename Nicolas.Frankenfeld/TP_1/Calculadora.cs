using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1
{
    class Calculadora
    {
        /// <summary>
        /// recibe dos numeros y un operador que realizan la operacion matematica solicitada
        /// </summary>
        /// <param name="numero1">objeto de la clase Numero</param>
        /// <param name="numero2">objeto de la clase Numero</param>
        /// <param name="operador">string con el operador a ser utilizado</param>
        /// <returns>retorna el resultado en tipo de dato double</returns>
        public static double operar(Numero numero1, Numero numero2, string operador)
        {
            double retorno =0;
            string auxOperador = Calculadora.validarOperador(operador);
            switch(auxOperador)
            {
                case "+":
                    retorno = numero1.GetNumero() + numero2.GetNumero();
                    break;

                case "-":
                    retorno = numero1.GetNumero() - numero2.GetNumero();
                    break;

                case "/":
                    if(numero2.GetNumero() == 0)
                    {
                        return retorno;
                    }
                    retorno = numero1.GetNumero() / numero2.GetNumero();
                    break;

                case "*":
                    retorno = numero1.GetNumero() * numero2.GetNumero();
                    break;
            }
            return retorno;
        }

        /// <summary>
        /// valida el operador, si no es uno de los esperados, retorna "+"
        /// </summary>
        /// <param name="operador">recibe un string</param>
        /// <returns>retorna el operadro en formato string</returns>
        public static string validarOperador(string operador)
        {
            string retorno = "+";
            if (operador != "+" && operador != "-" && operador != "/" && operador != "*")
            {
                return retorno;
            }
            else
            {
                retorno = operador;
            }
            return retorno;
        }

    }
}
