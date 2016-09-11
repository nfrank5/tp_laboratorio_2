using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1
{
    class Calculadora
    {
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
