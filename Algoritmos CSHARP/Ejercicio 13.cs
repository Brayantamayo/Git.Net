using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el total de horas trabajadas :");
            int horasTrabajadas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el valor por hora, segun su salario :");
            double valorPorHora = Convert.ToDouble(Console.ReadLine());

            double salario=horasTrabajadas * valorPorHora;

            Console.WriteLine("El salario es: " + salario.ToString("C"));

        }
    }
}
