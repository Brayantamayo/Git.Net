using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el tiempo que tarda en llenarse el balde más pequeño (en horas):");
            double tiempoBaldePequeno = Convert.ToDouble(Console.ReadLine());

            double tiempoBaldeMediano = tiempoBaldePequeno * 3;
            double tiempoBaldeGrande = tiempoBaldePequeno * 5;

            Console.WriteLine("\n--- Tiempos de llenado ---");
            Console.WriteLine("Balde pequeño (1x): " + tiempoBaldePequeno + " horas");
            Console.WriteLine("Balde mediano (3x): " + tiempoBaldeMediano + " horas");
            Console.WriteLine("Balde grande (5x): " + tiempoBaldeGrande + " horas");

        }
    }
}
