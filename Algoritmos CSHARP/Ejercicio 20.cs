using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el precio de compra unitario del producto:");
            double precioUnitario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de compra del producto:");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el descuento (en porcentaje, por ejemplo 10 para 10%):");
            double descuentoPorcentaje = Convert.ToDouble(Console.ReadLine());

            // Calcular subtotal
            double subtotal = precioUnitario * cantidad;

            // Calcular descuento en dinero
            double descuento = (descuentoPorcentaje / 100) * subtotal;

            // Subtotal con descuento aplicado
            double subtotalConDescuento = subtotal - descuento;

            // Calcular IVA (19%)
            double iva = subtotalConDescuento * 0.19;

            // Calcular precio neto
            double precioNeto = subtotalConDescuento + iva;

            // Mostrar resultados
            Console.WriteLine("\n--- Factura ---");
            Console.WriteLine("Subtotal (sin descuento): $" + subtotal);
            Console.WriteLine("Descuento aplicado: $" + descuento);
            Console.WriteLine("Subtotal con descuento: $" + subtotalConDescuento);
            Console.WriteLine("IVA (19%): $" + iva);
            Console.WriteLine("Precio neto a pagar: $" + precioNeto);
        }
    }
}
