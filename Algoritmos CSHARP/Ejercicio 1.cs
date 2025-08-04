using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string numero1, numero2;
            int a,b,c;
            Console.WriteLine("Introduzca dos numeros...");

            numero1 = Console.ReadLine();
            numero2 = Console.ReadLine();

            a=Convert.ToInt32(numero1);
            b=Convert.ToInt32(numero2);

            c = a + b;

            Console.WriteLine("El resultado de la suma es : "+ c);

            
        }
    }
}
