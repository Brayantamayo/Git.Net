using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de metros que desea subir el escalador:");
            double metrosDeseados = Convert.ToDouble(Console.ReadLine());

            double velocidadSubida = 7.0 / 5.0; // metros por hora
            double tiempoNecesario = metrosDeseados / velocidadSubida;

            Console.WriteLine("\n--- Resultado ---");
            Console.WriteLine("Metros a subir: " + metrosDeseados + " m");
            Console.WriteLine("Velocidad de subida: " + velocidadSubida + " m/h");
            Console.WriteLine("Tiempo estimado: " + tiempoNecesario + " horas");

        }
    }
}
