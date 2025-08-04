using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su salario : ");
            double salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del ahorro mensual : ");
            double ahorroMensual = Convert.ToDouble(Console.ReadLine());

            double EPS = salario * 0.125;
            double pension = salario * 0.16;
            double ahorroAnual = ahorroMensual * 12;
            double descuento = EPS + pension;
            double salarioNeto = salario - descuento;

            Console.WriteLine("El descuento por EPS es: " + EPS.ToString("C"));
            Console.WriteLine("El descuento por pensión es: " + pension.ToString("C"));
            Console.WriteLine("El ahorro anual es: " + ahorroAnual.ToString("C"));
            Console.WriteLine("El descuento total es: " + descuento.ToString("C"));
            Console.WriteLine("El salario neto es: " + salarioNeto.ToString("C"));






        }
    }
}
