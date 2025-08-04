using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese las 3 notas parciales  : ");
            
            Console.WriteLine("Nota 1 ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 2 ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 3 ");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            ///////////////////////////////////////////////

            Console.WriteLine("Ingrese la nota del examen final : ");
            double examenFinal = Convert.ToDouble(Console.ReadLine());

            ////////////////////////////////////////////////////////

            Console.WriteLine("Ingrese la nota del trabajo final : ");
            double trabajoFinal = Convert.ToDouble(Console.ReadLine());


            double promedio= (nota1 + nota2 + nota3) / 3;
            double notaFinal = (promedio * 0.55) + (examenFinal * 0.30) + (trabajoFinal * 0.15);

            Console.WriteLine("El promedio de las notas parciales es: " + promedio.ToString("C"));
            Console.WriteLine("La nota final del curso es: " + notaFinal.ToString("C"));

            if (notaFinal >= 3)
            {
                Console.WriteLine("El alumno ha aprobado el curso.");
            }
            else
            {
                Console.WriteLine("El alumno no ha aprobado el curso.");
            }





        }
    }
}
