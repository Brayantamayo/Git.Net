using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEjercicio_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el monto del préstamo:");
            double montoPrestamo = Convert.ToDouble(Console.ReadLine());

            double tasaInteresAnual = 0.05;
            int plazoAnios = 5;

            // Interés total en 5 años
            double interesTotal = montoPrestamo * tasaInteresAnual * plazoAnios;

            // Interés en 1 año
            double interesAnual = montoPrestamo * tasaInteresAnual;

            // Interés en el tercer trimestre del año (es decir, del mes 7 al 9)
            double interesTrimestre = interesAnual / 4; // cada trimestre representa 1/4 del año

            // Interés en el primer mes
            double interesMensual = interesAnual / 12;

            // Total a pagar (capital + intereses)
            double totalPagar = montoPrestamo + interesTotal;

            // Mostrar resultados
            Console.WriteLine("\n--- Detalles del Préstamo ---");
            Console.WriteLine("Monto del préstamo: $" + montoPrestamo);
            Console.WriteLine("Interés pagado en 1 año: $" + interesAnual);
            Console.WriteLine("Interés pagado en el 3er trimestre: $" + interesTrimestre);
            Console.WriteLine("Interés pagado en el 1er mes: $" + interesMensual);
            Console.WriteLine("Total a pagar en 5 años (capital + intereses): $" + totalPagar);

        }
    }
}
