using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diga el valor de su compra total :  ");
            double compra = Convert.ToDouble(Console.ReadLine());

            double descuento = compra * 0.15;
            double total = compra - descuento;

            Console.WriteLine("Su compra le sale por un valor de :"+total.ToString("C"));
        }
    }
}
