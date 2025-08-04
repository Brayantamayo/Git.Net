using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INGRESE EL PRECIO DE SUS 4 PRODUCTOS");
            double precio = Convert.ToDouble(Console.ReadLine());
            double precio2 = Convert.ToDouble(Console.ReadLine());
            double precio3 = Convert.ToDouble(Console.ReadLine());
            double precio4 = Convert.ToDouble(Console.ReadLine());

            double iva = (precio + precio2 + precio3 + precio4) * 0.19;
            double Total= (precio + precio2 + precio3 + precio4) + iva;



            Console.WriteLine("El Total a pagar es :"+ Total.ToString("C")  );

        }
    }
}
