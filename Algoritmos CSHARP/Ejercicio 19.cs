using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el nombre del estudiante : ");
            string nombre= Console.ReadLine();

            Console.WriteLine("Ingrese al curso al que pertenece el estudiante : ");
            string curso= Console.ReadLine();

            Console.WriteLine("Ingrese el numero de la ficha");
            double ficha=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese las 5 notas del estudiante del curso : ");

            Console.WriteLine("Primera Nota:");
            double nota1=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Segunda nota: ");
            double nota2=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Tercera Nota: ");
            double nota3=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Cuarta Nota: ");
            double nota4=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Quinta nota: ");
            double nota5=Convert.ToDouble(Console.ReadLine());


            double promedio= (nota1+nota2+nota3+nota4+nota5)/5;

            Console.WriteLine("\n--- Información del Estudiante ---");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Curso: " + curso);
            Console.WriteLine("Número de ficha: " + ficha);
            Console.WriteLine("Notas: " + nota1 + ", " + nota2 + ", " + nota3 + ", " + nota4 + ", " + nota5);
            Console.WriteLine("Promedio: " + promedio);



        }
    }
}
