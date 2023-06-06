using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_Precio_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuánto tiempo ha permanecido en el parking? Introduzca el tiempo en minutos (ej: 1 hora = 60, 2 horas = 120)");
            int hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Debe abonar la cantidad de {0} euros", hoursToEuros(hours));
        }

        public static double hoursToEuros(int h)
        {
            double euros = 0.00;

            if(h == 60)
            {
                euros = 5.00;
            } else if (h > 60 && h < 120)
            {
                euros = 10.00;
            } else if (h == 120)
            {
                euros = 15.00;
            } else if (h > 120)
            {
                euros = 40.00;
            }

            return euros;
        }
    }
}
