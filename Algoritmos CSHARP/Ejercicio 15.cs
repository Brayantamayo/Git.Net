using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el monto de la venta:");
            Console.Write("Monto 1 : ");
            double monto = Convert.ToDouble(Console.ReadLine());

            double iva = monto * 0.19;
            double total = monto + iva;
            
            
            Console.WriteLine("EL TOTAL A PAGAR ES : "+ total.ToString("C"));

            Console.WriteLine("SU METODO DE PAGO ES : ");
            Console.WriteLine("1. Efectivo");
            Console.WriteLine("2. Tarjeta de crédito");
            Console.Write("Seleccione una opción (1 o 2): ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Usted ha seleccionado pagar en efectivo.");
                    break;
                case 2:
                    Console.WriteLine("Usted ha seleccionado pagar con tarjeta de crédito.");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione 1 o 2.");
                    break;
            }

            Console.WriteLine("TOTAL PAGADO : ");
            double pago = Convert.ToDouble(Console.ReadLine());

            double cambio = pago - total;
            Console.WriteLine("SU CAMBIO ES : " + cambio.ToString("C"));









        }
    }
}
