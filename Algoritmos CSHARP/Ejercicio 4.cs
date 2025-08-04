using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe las notas del estudiante:");

            Console.WriteLine("Nota 1 del 20%: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 2 del 30% :");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 3 del 50% : ");
            double n3 = Convert.ToDouble(Console.ReadLine());


            double valor1 = n1 * 0.2;
            double valor2 = n2 * 0.3;
            double valor3= n3 * 0.5;

            double Nota= (valor1+valor2+ valor3);
            Console.WriteLine("El promedio del estudiante es: " + Math.Round(Nota, 2));




        }
    }
}
