using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorenoJuanEntornoFinal.Valida
{
    public class valida
    {

        /// <summary>
        /// valida que sea un numero double
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static Double ValidarDouble(double numero)
        {
            bool escorrecto = true;
            String cadena = null;
            do
            {
                cadena = Console.ReadLine();
                escorrecto = Double.TryParse(cadena, out numero);
                if (!escorrecto)
                {
                    Console.WriteLine("Error dato incorrecto");
                }
            } while (!escorrecto);

            return numero;

        }

        public static int ValidarInt(int numero)
        {
            String cadena = null;
            bool escorrecto = true;
            do
            {
                cadena = Console.ReadLine();
                escorrecto = Int32.TryParse(cadena, out numero);
                if (!escorrecto)
                {
                    Console.WriteLine("Error dato incorrecto");
                }

            } while (!escorrecto);
            return numero;
        }
    }
}
