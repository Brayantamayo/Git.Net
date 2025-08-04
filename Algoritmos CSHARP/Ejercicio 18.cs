using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor de su deuda");
            double inicial=Convert.ToDouble(Console.ReadLine());

            double primera = inicial * 0.40;
            double segunda = inicial * 0.25;
            double tercera = inicial * 0.20;
            double cuarta = inicial * 0.15;

            Console.WriteLine("La primera cuota tiene que pagar "+primera.ToString("C"));
            Console.WriteLine("La segunda cuota tiene que pagar " + segunda.ToString("C"));
            Console.WriteLine("La tercera cuota tiene que pagar "+tercera.ToString("C"));
            Console.WriteLine("La cuarta cuota  tiene que pagar " + cuarta.ToString("C"));
           

        }
    }
}
