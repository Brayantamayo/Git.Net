using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string numero1, numero2;
            int n, c, m, d, r, s;
            Console.WriteLine("Ingresa dos numeros");
            numero1 = Console.ReadLine();
            numero2 = Console.ReadLine();

            n=Convert.ToInt32(numero1);
            c = Convert.ToInt32(numero2);

            s= n+c;
            m = n * c;
            d = n / c;
            r = n - c;

            Console.WriteLine("El resultado de la suma es : " +s+ "\n"+ "El resultado de la Multiplicacion es: "+m+ "\n" +
                "El resultado de la Division es : " +d+ "\n" + "El resultado de la resta es :" + r);


            
        }
    }
}
