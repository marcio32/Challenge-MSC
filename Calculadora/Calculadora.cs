using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Calculadora : Menu
    {
        /// <summary>
        /// Metodo para realizar una operacion basica
        /// </summary>
        /// <param name="num1">Primer Numero</param>
        /// <param name="num2">Segundo Numero</param>
        /// <param name="queQuieresHacer">Selecciona la operacion</param>
        /// <returns>Retorna el valor calculado</returns>
        public static int Calcular(int num1, int num2, int queQuieresHacer)
        {
            return queQuieresHacer switch
            {
                1 => num1 + num2,
                2 => num1 - num2,
                3 => num1 * num2, 
                4 => num1 / num2, 
                _ => 0
            };
        }

    }
}
