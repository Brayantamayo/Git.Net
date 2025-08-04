using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el nombre del aprendiz:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la dirección del aprendiz:");
            string direccion = Console.ReadLine();

            Console.WriteLine("Ingrese el año de nacimiento del aprendiz:");
            int anioNacimiento = Convert.ToInt32(Console.ReadLine());

            int anioActual = DateTime.Now.Year;
            int edad = anioActual - anioNacimiento;

            Console.WriteLine("\n--- Información del Aprendiz ---");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Dirección: " + direccion);
            Console.WriteLine("Año de nacimiento: " + anioNacimiento);
            Console.WriteLine("Edad: " + edad + " años");

        }
    }
}
