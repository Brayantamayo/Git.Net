using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de su capital que desea invertir : ");
            double inversion=double.Parse(Console.ReadLine());

            double ganancias = inversion * 0.2;
            double total = inversion + ganancias;

            Console.WriteLine("El total de ganancias al mes es : " + total.ToString("C"));

        }
    }
}
