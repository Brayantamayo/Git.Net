using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Ingrese el valor de las ventas realizadas");

            Console.WriteLine("Venta 1 : ");
            double Venta1=double.Parse(Console.ReadLine());

            Console.WriteLine("Venta 2 : ");
            double Venta2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Venta 3 : ");
            double Venta3 = double.Parse(Console.ReadLine());


            Console.WriteLine("Ingrese su Salario Base");
            double salario = double.Parse(Console.ReadLine());


            double comision = (Venta1 + Venta2 + Venta3) * 0.10;
            double total = salario + comision;

            Console.WriteLine("Su salario con las comisiones es :"+total.ToString("C"));
        }
    }
}
