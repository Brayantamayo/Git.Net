using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese las ganancias del dia de hoy : ");
            double ganacias = double.Parse(Console.ReadLine());

            double totalGanancias = ganacias*0.19;

            Console.WriteLine("El total de ganancias del dia de hoy es: " + totalGanancias.ToString("C"));




        }
    }
}
