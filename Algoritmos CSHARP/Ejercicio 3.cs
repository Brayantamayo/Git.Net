using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe las notas del estudiante:");

            Console.WriteLine("Nota 1: ");
            double n1=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 2 :");
            double n2=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 3: ");
            double n3=Convert.ToDouble(Console.ReadLine());

            double promedio =(n1+n2+n3)/3;

            Console.WriteLine("El promedio del estudiante es: " + Math.Round(promedio, 2)); /// Redondear el número promedio a 2 decimales.
        }
    }
}
